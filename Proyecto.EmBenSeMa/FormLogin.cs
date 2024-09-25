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
        private LoginService loginService = new LoginService();
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
            FormMessage formMessage = new FormMessage();

            if (txtUsuario.Text != "" || txtContrasena.Text != "")
            {
                if (loginService.LoginValido(txtUsuario.Text, txtContrasena.Text))
                {
                    MessageBox.Show("Ha iniciado correctamente!!! " + txtUsuario.Text);
                    if (etqPlataforma.Text == "Plataforma para Alumnos")
                    {

                        viewStudent.Show();
                        viewStudent.ShowData(loginService.UserSession());
                    }
                    else
                    {
                        viewTeachear.Show();
                        viewTeachear.ShowData(loginService.UserSession());
                    }
                }
                else
                {
                    formMessage.Show();
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

            // Personaliza el título según el valor de nameForm
            if (etqPlataforma.Text == "Plataforma para Profesores")
            {
                nuevoReg.ShowCourse("Nuevo Profesor");
            }
            else
            {
                nuevoReg.ShowCourse("Nuevo Alumno");
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
        // Limpiar campos y cambiar titulo
        public void ChangeTitle(string tipo)
        {
            this.tipo = loginService.TipoUser(tipo);
            etqPlataforma.Text = "Plataforma para " + tipo;
        }
        // Cambiar contraseña
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Activo
            etqPlataforma.Text = "Recuperar contraseña";
            ChangePassword();
        }
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtContrasena.Text == "")
            {
                MessageBox.Show("Completa los campos requeridos");
            }
            else
            {
                if (tipo == "Student")
                {
                    if (loginService.RecoverPasswordStudent(txtContrasena.Text, txtUsuario.Text))
                    {
                        MessageBox.Show("Te enviamos un correo a tu email");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hay errores en la validación de tu usuario");
                        this.Close();
                    }
                }
                else
                {
                    if (loginService.RecoverPasswordTeacher(txtContrasena.Text, txtUsuario.Text))
                    {
                        MessageBox.Show("Te enviamos un correo a tu email");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hay errores en la validación de tu usuario");
                        this.Close();
                    }
                }
            }
        }
        private void ChangePassword()
        {
            txtUsuario.Text = "";
            txtContrasena.Text = "";
            etqUsuario.Text = "Tu email:";
            etqPass.Text = "Ingresar dni:";
            txtUsuario.PlaceholderText = "Ingrese su email";
            txtContrasena.PlaceholderText = "Ingrese tu dni";
            btnInicio.Visible = false;
            btnRegistrarse.Visible = false;
            checkMostrar.Visible = false;
            checkMostrar.Checked = true;
            linkCambiar.Visible = false;
            btnCambiar.Visible = true;
            btnVolver.Visible = true;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            if(tipo == "Student")
            {
                ChangeTitle("Alumnos");
            }
            else
            {
                ChangeTitle("Profesores");
            }
            txtUsuario.Text = "";
            txtContrasena.Text = "";
            etqUsuario.Text = "Usuario:";
            etqPass.Text = "Contraseña:";
            txtUsuario.PlaceholderText = "Ingrese su usuario";
            txtContrasena.PlaceholderText = "Ingrese tu Contraseña";
            btnInicio.Visible = true;
            btnRegistrarse.Visible = true;
            checkMostrar.Visible = true;
            checkMostrar.Checked = false;
            linkCambiar.Visible = true;
            btnCambiar.Visible = false;
            btnVolver.Visible = false;
        }
    }
}
