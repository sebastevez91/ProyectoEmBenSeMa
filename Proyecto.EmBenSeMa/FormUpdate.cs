using Capa.Servicios;
using SchoolMusic.Entidades;
using SchoolMusic.Serv;

namespace SchoolMusic.Proyecto
{
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }
        UpdateService updateService = new UpdateService();
        Users updateUser = null;
        private int idStudent;
        private int idTeacher;
        private int idUser;
        // Datos del usuario
        public void SetUsers(Users userSession)
        {
            idUser = userSession.IdUser;
            txtUsuario.Text = userSession.Username;
            txtContra.Text = userSession.Password;
        }
        public void SetStudent(Student student)
        {
            idStudent = student.IdStudent;
            txtNombre.Text = student.Name;
            txtApellido.Text = student.Surname;
            txtDni.Text = student.Dni.ToString();
            txtEdad.Text = student.Age.ToString();
            txtCorreo.Text = student.Mail;
        }
        public void SetTeacher(Teacher teacher)
        {
            idTeacher = teacher.IdTeacher;
            txtNombre.Text = teacher.NameTeacher;
            txtApellido.Text = teacher.Surname;
            txtDni.Text = teacher.Dni.ToString();
            txtEdad.Text = teacher.Age.ToString();
            txtCorreo.Text = teacher.Mail;
        }
        // Botones
        private void button1_Click(object sender, EventArgs e)
        {
            if(boxDatPer.Visible == false)
            {
                boxDatPer.Visible = true;
                pictMate.Visible = true;
            }
            else
            {
                boxDatPer.Visible = false;
                pictMate.Visible = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Users updateUser = new Users();
            Student updateStudent = new Student();
            Teacher updateTeacher = new Teacher();
            if (txtUsuario.Text != null && txtUsuario.Text != "" && txtContra.Text != null && txtContra.Text != "")
            {
                updateUser.IdUser = idUser;
                updateUser.Username = txtUsuario.Text;
                updateUser.Password = txtContra.Text;
                if (boxDatPer.Visible)
                {
                    if (ValidacionGeneral.ActualizaRegistro(txtNombre.Text, txtApellido.Text, txtDni.Text, txtEdad.Text, txtCorreo.Text))
                    {
                        if (etqUpdate.Text == "Alumno")
                        {
                            updateStudent.IdStudent = idStudent;
                            updateStudent.Name = txtNombre.Text;
                            updateStudent.Surname = txtApellido.Text;
                            updateStudent.Dni = int.Parse(txtDni.Text);
                            updateStudent.Age = int.Parse(txtEdad.Text);
                            updateStudent.Mail = txtCorreo.Text;
                            updateService.UpdateStudent(updateStudent);
                        }
                        else
                        {
                            updateTeacher.IdTeacher = idTeacher;
                            updateTeacher.NameTeacher = txtNombre.Text;
                            updateTeacher.Surname = txtApellido.Text;
                            updateTeacher.Dni = int.Parse(txtDni.Text);
                            updateTeacher.Age = int.Parse(txtEdad.Text);
                            updateTeacher.Mail = txtCorreo.Text;
                            updateService.UpdateTeacher(updateTeacher);
                        }
                    }
                }
                if (updateService.UpdateUsers(updateUser))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Revisa los datos ingresados");
                }
            }
        }
        // Check Mostrar contraseña
        private void checkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (txtContra.PasswordChar == '*')
            {
                txtContra.PasswordChar = '\0';
                txtConfirma.PasswordChar = '\0';
            }
            else
            {
                txtContra.PasswordChar = '*';
                txtConfirma.PasswordChar = '*';
            }
        }
    }
}
