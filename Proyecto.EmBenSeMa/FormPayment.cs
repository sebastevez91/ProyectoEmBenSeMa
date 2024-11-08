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
        List<Payment> listPayment = new List<Payment>();
        List<Inscription> listInscription = new List<Inscription>();

        PayService payService = new PayService();
        public void ShowPaymentStudent(Student student, string typeUser)
        {
            if(typeUser == "Teacher")
            {
                btnPagar.Enabled = false;
            }
            else
            {
                btnPagar.Enabled = false;
            }
            listInscription.Clear();
            listPayment.Clear();
            listInscription = payService.GetInscriptions(student.IdStudent);
            foreach (Inscription i in listInscription)
            {
                listPayment.Add(payService.GetPayment(i.idInscription));
            }

            comboPay.DataSource = null;
            comboPay.DataSource = listPayment;
            comboPay.DisplayMember = "IdInscription";
            comboPay.ValueMember = "IdPayment";
            comboPay.SelectedIndex = -1;
            
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
                if (payService.PaymentCuota(int.Parse(comboPay.SelectedValue.ToString()), comboMetodo.SelectedItem.ToString()))
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
            foreach (Payment payment in listPayment)
            {
                if (comboPay.SelectedValue.ToString() == payment.IdPayment.ToString())
                {
                    eqtEstado.Visible = true;
                    eqtEstado.Text = $"Detalles de cuota con fecha " + payment.DatePayment.ToString() +" \n" +
                        "El estado de la cuota es : " + payment.PaymentStatus.ToString();
                    btnPagar.Visible = payment.PaymentStatus == "Pendiente";
                    etqMetodo.Visible = payment.PaymentStatus == "Pendiente";
                    comboMetodo.Visible = payment.PaymentStatus == "Pendiente";
                    if (payment.TypePay == "Pagada")
                    {
                        eqtEstado.Text += "\nMetodo :" + payment.TypePay;
                    }
                }
            }
        }
    }
}

