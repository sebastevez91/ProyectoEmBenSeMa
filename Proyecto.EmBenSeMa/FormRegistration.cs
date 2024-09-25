using Capa.Servicios;
using SchoolMusic.Entidades;
using SchoolMusic.Serv;

namespace Proyecto.EmBenSeMa
{
    public partial class FormRegistration : Form
    {
        // Creamos instancias y listas que vamos a utilizar en este Form
        private RegistroService registroService = new RegistroService();
        private Users user = new Users();
        private Student student = new Student();
        private Teacher teacher = new Teacher();
        public FormRegistration()
        {
            InitializeComponent();
        }

        // Botones
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // logitud de contraseña
            if (txtContra.Text.Length < 8)
            {
                // Si es true se muestra la eqtNotifica
                etqNotifica.Visible = true;
            }
            // Compruebo que el gruopBox este seleccionado y almaceno en la variable según la selección entre los radiusButton
            string generoSeleccionado = raBtnFem.Checked ? "Femenino" : "Masculino";

            // Validación de registro.
            // Valido los datos con una clase de validaciones generales en la capa servicio 
            if (ValidacionGeneral.validaRegistro(txtNombre.Text,
                txtApellido.Text,
                txtDni.Text,
                txtEdad.Text,
                txtCorreo.Text,
                txtUsuario.Text,
                txtContra.Text,
                txtConfirma.Text))
            {
                // Si todos los campos son válidos se agrega el usuario a la base de datos.
                // User
                user.Username = txtUsuario.Text;
                user.Password = txtContra.Text;
                if (registroService.AddUser(user))
                {
                    // Compruebo que tipo de usuario voy a registrar en la BD
                    if (etqRegistro.Text == "Nuevo Alumno")
                    {
                        // Nuevo Alumno
                        student.Name = txtNombre.Text;
                        student.Surname = txtApellido.Text;
                        student.Mail = txtCorreo.Text;
                        student.Dni = int.Parse(txtDni.Text);
                        student.Age = int.Parse(txtEdad.Text);
                        student.IdUser = registroService.GetIdUser(user);
                        student.Genero = generoSeleccionado;

                        // Agrego el nuevo alumno y traigo el Id del alumno
                        registroService.AddStudent(student);
                    }
                    else
                    {
                        // Nuevo Profesor
                        teacher.NameTeacher = txtNombre.Text;
                        teacher.Surname = txtApellido.Text;
                        teacher.Mail = txtCorreo.Text;
                        teacher.Dni = int.Parse(txtDni.Text);
                        teacher.Age = int.Parse(txtEdad.Text);
                        teacher.IdUser = registroService.GetIdUser(user);
                        teacher.Genero = generoSeleccionado;

                        // Agrego nuevo profesor y traigo el Id del profesor
                        registroService.AddTeacher(teacher);
                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Revisa los campos, se encontraron errores");
            }
        }
        // Campos númericos
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Método para aceptar solo números en el textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Método para aceptar solo números en el textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Check para mostrar la contraseña
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
        // Cambiamos Titulo
        public void ShowCourse(string tipo)
        {
            etqRegistro.Text = tipo;
        }
    }
}