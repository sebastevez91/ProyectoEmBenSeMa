using SchoolMusic.Entidades;
using SchoolMusic.Serv;

namespace SchoolMusic.Proyecto
{
    public partial class FormPayment : Form
    {
        public FormPayment()
        {
            InitializeComponent();
        }
        // Creo Lista de tipo Payment y Inscription.
        List<Payment> listPay = new List<Payment>();
        List<Inscription> listInscrip = new List<Inscription>();
        List<Cursada> listCursada = new List<Cursada>();
        // Creamos una instancia de la entidad Payment.
        PayService payService = new PayService();
        // Creamos una intancia de Student en nulo.
        Student studentPay = null;
        public void ShowPay(Student student, List<Course> listCourse, List<Cursada> cursadas)
        {
            // Almaceno el Alumno que esta en sessón.
            studentPay = student;
            listCursada = cursadas;
            // En el comboCurso muestro los curso que está inscripto el alumno.
            comboCurso.DataSource = listCourse;
            comboCurso.DisplayMember = "Instrument";
            comboCurso.ValueMember = "IdCourse";
            // Pongo el indexe en -1 para que no muestre los datos cuando los almacena en el comboBox.
            comboCurso.SelectedIndex = -1;

            foreach (Cursada c in cursadas)
            {
                listInscrip.Add(payService.GetInscription(student.IdStudent, c.IdCursada));
            }
        }
        // Botones
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnVerPagar_Click(object sender, EventArgs e)
        {
            MostrarCuota();
        }
        // Pagar cuota
        private void btnPagar_Click(object sender, EventArgs e)
        {
            // Pregunto si quiere pagar
            DialogResult resp = MessageBox.Show("Estás seguro de que quieres pagar la cuota?", "Confirmación", MessageBoxButtons.YesNo);

            if (resp == DialogResult.Yes)
            {
                // Se envia la respuesta a la capa de Servicio
                if (payService.PaymentCuota(int.Parse(comboMesPagar.SelectedValue.ToString()), comboMetodo.SelectedItem.ToString()))
                {
                    MessageBox.Show("Pago exitoso!!!");
                    MostrarCuota();
                    btnPagar.Visible = false;
                    etqMetodo.Visible = false;
                    comboMetodo.Visible = false;
                }
                else
                {
                    MessageBox.Show("No se pudo abonar la cuota");
                }
            }
        }
        // Muestra cuota
        private void MostrarCuota()
        {
            // Mostramos la informacion de la cuota seleccionada
            foreach (Payment payment in listPay)
            {
                if (comboMesPagar.SelectedValue.ToString() == payment.IdPayment.ToString())
                {
                    eqtEstado.Visible = true;
                    eqtEstado.Text = $"Detalles de cuota: {payment.Month} / {payment.Year}\n" +
                        "El estado de la cuota es : " + payment.PaymentStatus.ToString();
                    btnPagar.Visible = payment.PaymentStatus == "Pendiente";
                    etqMetodo.Visible = payment.PaymentStatus == "Pendiente";
                    comboMetodo.Visible = payment.PaymentStatus == "Pendiente";
                    if (payment.Metodo == "Pagada")
                    {
                        eqtEstado.Text += "\nMetodo :" + payment.Metodo;
                    }
                }
            }
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            listPay.Clear();
            comboMesPagar.DataSource = null;
            int idInscription = 0;
            // Almaceno el IdInscription para buscar las cuotas según el registro de inscription.
            // Busco la inscripcion según el id del alumno.
            foreach (Cursada c in listCursada)
            {
                if (c.IdCourse == int.Parse(comboCurso.SelectedValue.ToString()))
                {
                    idInscription = payService.GetIdInscription(studentPay.IdStudent, c.IdCursada);
                    if (idInscription > 0)
                    {
                        // Limpio el comboBox
                        comboMesPagar.Items.Clear();
                        // Almaceno los pagos en una lista de tipo Payment
                        listPay = payService.GetPayment(idInscription);
                        // En el comboMesPagar muestro los meses de cada elemento en la lista
                        comboMesPagar.DataSource = listPay;
                        comboMesPagar.DisplayMember = "Fecha";
                        comboMesPagar.ValueMember = "IdPayment";
                        groupCuota.Visible = true;
                    }
                }
            }
        }
    }
}

