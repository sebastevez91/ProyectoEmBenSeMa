using Capa.Servicios;
using Microsoft.VisualBasic.ApplicationServices;
using SchoolMusic.Entidades;
using SchoolMusic.Serv;

namespace Proyecto.EmBenSeMa
{
    public partial class FormRegistration : Form
    {
        // Creamos instancias y listas que vamos a utilizar en este Form
        private RegistroService registroService = new RegistroService();
        private Users NewUser = null;
        private Student student = new Student();
        private Teacher teacher = new Teacher();
        private string rolUser;
        private string rolGenero;
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
            try
            {
                // Almaceno roles
                rolUser = raBtnAlumno.Checked ? "Alumno" : raBtnProfesor.Checked ? "Profesor" : null;
                rolGenero = raBtnFem.Checked ? "Femenino" : raBtnMas.Checked ? "Masculino" : null;

                // Validar campos generales
                if (!ValidarCampos())
                {
                    MessageBox.Show("Revisa los campos, se encontraron errores");

                    etqValidaciones.Text = "Verifica que Los campos cumplan los siguientes puntos:" +
                        "\n1 - Datos Personales correctamente." +
                        "\n2 - Email correctamente, con signo '@' y '.'" +
                        "\n3 - Nombre de usuario sin numero, puede contener Mayusculas y minusculas." +
                        "\n4 - Verifica que el rol de usuario este seleccionado" +
                        "\n5 - Contraseña de 8 digitos, letras, numeros y signos" +
                        "\n6 - Las 2 contraseñas ingresadas deben ser iguales.";

                    etqValidaciones.Visible = true;
                    // Validar contraseña
                    etqNotifica.Visible = txtContra.Text.Length < 8 ?  true : false;

                    return;
                }

                if (rolUser == null)
                {
                    MessageBox.Show("Debe seleccionar un rol de usuario (Alumno o Profesor).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (rolGenero == null)
                {
                    MessageBox.Show("Debe seleccionar un género (Femenino o Masculino).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear usuario
                var newUser = new Users
                {
                    Username = txtUsuario.Text,
                    UserPassword = txtContra.Text,
                    Rol = rolUser
                };


                // Registrar el usuario en la base de datos
                if (newUser.Username != null && newUser.UserPassword != null && newUser != null)
                {
                    newUser.IdUser = registroService.AddUser(newUser);
                    if (newUser.IdUser == null || newUser.IdUser <= 0)
                    {
                        MessageBox.Show("Error al registrar el usuario.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Revisa los campos de datos de usuario");
                    return;
                }
           

                // Registrar datos específicos según el rol
                if (newUser.Rol == "Alumno")
                {
                    var student = CrearAlumno(newUser.IdUser);
                    registroService.AddStudent(student);
                }
                else if (newUser.Rol == "Profesor")
                {
                    var teacher = CrearProfesor(newUser.IdUser);
                    registroService.AddTeacher(teacher);
                }

                MessageBox.Show("Registro exitoso.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}");
            }
        }

        // Métodos auxiliares

        private bool ValidarCampos()
        {
            return ValidacionGeneral.validaRegistro(
                txtNombre.Text, txtApellido.Text, txtDni.Text,
                txtEdad.Text, txtCorreo.Text, txtUsuario.Text,
                txtContra.Text, txtConfirma.Text
            );
        }

        private Student CrearAlumno(int userId)
        {
            return new Student
            {
                NameStudent = txtNombre.Text,
                Surname = txtApellido.Text,
                Mail = txtCorreo.Text,
                Dni = int.Parse(txtDni.Text),
                Age = int.Parse(txtEdad.Text),
                IdUser = userId,
                Genero = rolGenero
            };
        }

        private Teacher CrearProfesor(int userId)
        {
            return new Teacher
            {
                NameTeacher = txtNombre.Text,
                Surname = txtApellido.Text,
                Mail = txtCorreo.Text,
                Dni = int.Parse(txtDni.Text),
                Age = int.Parse(txtEdad.Text),
                IdUser = userId,
                Genero = rolGenero
            };
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