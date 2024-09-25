using SchoolMusic.Proyecto;

namespace Proyecto.EmBenSeMa
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        // Instancia del formulario
        private FormContact formContact;
        private FormCourse formCourse;
        private FormLogin formLogin;
        // Botones
        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            try
            {
                viewLogin("Alumnos");
                formLogin.Show();
            }
            catch (System.ObjectDisposedException)
            {

                MessageBox.Show("No se puede abrir más de una ventana", "Error de instanciación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnProfe_Click(object sender, EventArgs e)
        {
            try
            {

                viewLogin("Profesores");
                formLogin.Show();

            }
            catch (System.ObjectDisposedException)
            {

                MessageBox.Show("No se puede abrir más de una ventana", "Error de instanciación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnContacto_Click(object sender, EventArgs e)
        {
            try
            {
                viewContact();
                formContact.Show();
            }
            catch (System.ObjectDisposedException)
            {

                MessageBox.Show("No se puede abrir más de una ventana", "Error de instanciación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCursos_Click(object sender, EventArgs e)
        {
            try
            {
                viewCourse();
                formCourse.Show();
            }
            catch (System.ObjectDisposedException)
            {

                MessageBox.Show("No se puede abrir más de una ventana", "Error de instanciación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Ventanas de Formularios
        private void viewLogin(string nameForm)
        {
            // Verifica si ya existe una instancia del formulario
            if (formLogin == null || formLogin.IsDisposed)
            {
                // Si no existe, crea una nueva instancia
                formLogin = new FormLogin();
            }

            // Personaliza el título según el valor de nameForm
            if (nameForm == "Alumnos")
            {
                formLogin.ChangeTitle("Alumnos");
            }
            else
            {
                formLogin.ChangeTitle("Profesores");
            }

            // Verifica si el formulario está visible
            if (formLogin.Visible)
            {
                // Si está visible, cierra la instancia existente
                formLogin.Close();
            }

            // Muestra el formulario actual
            this.Visible = true;
        }
        private void viewContact()
        {
            // Verifica si ya existe una instancia del formulario
            if (formContact == null || formContact.IsDisposed)
            {
                // Si no existe, crea una nueva instancia
                formContact = new FormContact();
            }

            // Verifica si el formulario está visible
            if (formContact.Visible)
            {
                // Si está visible, cierra la instancia existente
                formContact.Close();
            }

            // Muestra el formulario actual
            this.Visible = true;
        }
        private void viewCourse()
        {
            // Verifica si ya existe una instancia del formulario
            if (formCourse == null || formCourse.IsDisposed)
            {
                // Si no existe, crea una nueva instancia
                formCourse = new FormCourse();
            }

            // Verifica si el formulario está visible
            if (formCourse.Visible)
            {
                // Si está visible, cierra la instancia existente
                formCourse.Close();
            }

            // Muestra el formulario actual
            this.Visible = true;
        }
    }
}
