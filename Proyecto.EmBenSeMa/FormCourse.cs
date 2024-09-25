using SchoolMusic.Entidades;
using SchoolMusic.Serv;

namespace Proyecto.EmBenSeMa
{
    public partial class FormCourse : Form
    {
        public FormCourse()
        {
            InitializeComponent();
            courses.Clear();
        }
        private CourseService courseService = new CourseService();
        List<Course> courses = new List<Course>();
        List<Cursada> listCursadas = new List<Cursada>();
        private Student student = null;
        private FormLogin login = new FormLogin();
        private Cursada cursada = new Cursada();
        private string tipoCurso = "";
        private int idInscription;
        public void StudentCourse(Student student)
        {
            this.student = student;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Mensaje(string curso)
        {
            // Limpio los controles
            etqInfo.Text = "";
            btnInscription.Visible = false;
            //Muestro el gruopBox
            grBoxInfo.Visible = true;
            tipoCurso = curso;
            courses = courseService.GetListCourse();
            comboCursada.DataSource = null;
            etqTitle.Text = $"Curso de {tipoCurso}";

            foreach (Course c in courses)
            {
                if (c.Instrument == curso)
                {
                    listCursadas = courseService.GetListCursadas(c.IdCourse);
                    if (listCursadas.Count > 0)
                    {
                        comboCursada.DataSource = listCursadas;
                        comboCursada.DisplayMember = "StartTime";
                        comboCursada.ValueMember = "IdCursada";
                    }
                    else
                    {
                        MessageBox.Show("No hay cursadas disponibles");
                        grBoxInfo.Visible = false;
                        etqInfo.Visible = false;
                    }
                }
            }
            comboCursada.SelectedIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mensaje("Piano");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mensaje("Guitarra");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mensaje("Bateria");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mensaje("Saxo");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mensaje("Bajo");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Mensaje("Canto");
        }
        private void Muestra()
        {
            string nameTeacher = "";
            int inscriptos = 0;
            etqInfo.Visible = true;
            if (comboCursada.SelectedValue == null)
            {
                MessageBox.Show("No seleccionaste ninguna cursada");
            }
            else
            {
                inscriptos = courseService.GetCantidad(int.Parse(comboCursada.SelectedValue.ToString()));
                foreach (Cursada c in listCursadas)
                {
                    if (c.IdCursada == int.Parse(comboCursada.SelectedValue.ToString()))
                    {
                        etqInfo.Text = $"Fecha de inicio: {c.Initiation.ToString("dd/MM/yyyy")}\n" +
                            $"Fecha de finalización: {c.Finish.ToString("dd/MM/yyyy")}\n" +
                            $"Vacantes disponibles: {inscriptos} / {c.Vacantes}\n" +
                            $"Profesor {courseService.GetNameTeacher(c.IdTeacher)}\n" +
                            $"Dia de cursada: {c.Days}\n" +
                            $"Contenido: {c.Description}\n" +
                            $"Arancel de cuota $ {c.PayFee}";
                        cursada = c;
                    }
                }
                btnInscription.Visible = true;
            }


        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Muestra();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            idInscription = 0;
            DialogResult result = MessageBox.Show($"¿Quieres inscribirte en el curso {tipoCurso}?", "Incripción", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (student == null)
                {
                    login.Show();
                    this.Close();
                }
                else
                {
                    idInscription = courseService.GetIdInscription(student.IdStudent, cursada.IdCursada);
                    if (idInscription <= 0)
                    {
                        if (courseService.AddInscription(student.IdStudent, cursada.IdCursada))
                        {
                            idInscription = courseService.GetIdInscription(student.IdStudent, cursada.IdCursada);
                            if (courseService.AddPayment(idInscription, cursada))
                            {
                                MessageBox.Show("Inscripción exitosa!!");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo completar la inscriptción!!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se pudo completar la inscriptción!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya estas inscripto en este curso");
                    }

                }

            }
        }
    }
}
