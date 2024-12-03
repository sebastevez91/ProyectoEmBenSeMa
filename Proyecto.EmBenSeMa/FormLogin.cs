using SchoolMusic.BD;
using SchoolMusic.Entidades;
using SchoolMusic.Proyecto;
using SchoolMusic.Serv;

namespace Proyecto.EmBenSeMa
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        // Instancia de formulario registro
        private FormRegistration nuevoReg;
        private RecoverPassword RecoverPassword;
        private LoginService loginService = new LoginService();
        private Users UserSesion = null; 
        private string tipo = "";
        // Botones y checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // CheckBox que oculta y muestra la contraseña ingresada
            if (txtContrasena.PasswordChar == '*')
            {
                txtContrasena.PasswordChar = '\0';
            }
            else
            {
                txtContrasena.PasswordChar = '*';
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            FormStudent viewStudent = new FormStudent();
            FormTeacher viewTeachear = new FormTeacher();

            if (txtUsuario.Text != "" || txtContrasena.Text != "")
            {
                UserSesion = loginService.LoginValido(txtUsuario.Text, txtContrasena.Text);
                if (UserSesion != null)
                {
                    MessageBox.Show("Ha iniciado correctamente!!! " + txtUsuario.Text);
                    if (UserSesion.Rol == "Alumno")
                    {

                        viewStudent.Show();
                        viewStudent.ShowData(UserSesion);
                    }
                    else if (UserSesion.Rol == "Profesor")
                    {
                        viewTeachear.Show();
                        viewTeachear.ShowData(UserSesion);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no registrado!");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Se requiere llenar los campos para iniciar sesión");
            }
        }
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                viewRegistrar();
                nuevoReg.Show();
            }
            catch (System.ObjectDisposedException)
            {

                MessageBox.Show("No se puede abrir más de una ventana", "Error de instanciación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Ventanas
        private void viewRegistrar()
        {
            // Verifica si ya existe una instancia del formulario
            if (nuevoReg == null || nuevoReg.IsDisposed)
            {
                // Si no existe, crea una nueva instancia
                nuevoReg = new FormRegistration();
            }

            // Verifica si el formulario está visible
            if (nuevoReg.Visible)
            {
                // Si está visible, cierra la instancia existente
                nuevoReg.Close();
            }

            // Muestra el formulario actual
            this.Visible = true;
        }
        private void viewRecoverPassword()
        {
            // Verifica si ya existe una instancia del formulario
            if (RecoverPassword == null || RecoverPassword.IsDisposed)
            {
                // Si no existe, crea una nueva instancia
                RecoverPassword = new RecoverPassword();
            }

            // Verifica si el formulario está visible
            if (RecoverPassword.Visible)
            {
                // Si está visible, cierra la instancia existente
                RecoverPassword.Close();
            }

            // Muestra el formulario actual
            this.Visible = true;
        }
        // Cambiar contraseña
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                viewRecoverPassword();
                RecoverPassword.Show();
            }
            catch (System.ObjectDisposedException)
            {

                MessageBox.Show("No se puede abrir más de una ventana", "Error de instanciación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
