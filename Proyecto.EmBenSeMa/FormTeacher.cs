using Proyecto.EmBenSeMa;
using SchoolMusic.Entidades;
using SchoolMusic.Serv;

namespace SchoolMusic.Proyecto
{
    public partial class FormTeacher : Form
    {
        public FormTeacher()
        {
            InitializeComponent();
        }
        // Declaración de variables globales
        private TeacherService teacherService = new TeacherService();
        List<Student> listStudent = new List<Student>();
        private FormUpdate updateTeacher = new FormUpdate();
        private FormNotification notification;
        private FormContact formContact;
        private FormTablon formTablon;
        private Users userSession = null;
        private Teacher teacher = new Teacher();
        private Course course = new Course();
        private List<Cursada> listCursada = new List<Cursada>();
        private int selectValue;
        public void ShowData(Users userSession)
        {
            this.userSession = userSession;
            teacher = teacherService.GetTeacher(userSession.IdUser);
            listCursada = teacherService.GetCursadaList(teacher.IdTeacher);

            if (teacher != null)
            {
                // Datos personales
                eqtTitulo.Text += $"Profesor {teacher.NameTeacher}";
                txtNombreCompleto.Text = teacher.NameTeacher + " " + teacher.Surname;
                txtDni.Text = teacher.Dni.ToString();
                txtMail.Text = teacher.Mail;

                // Datos Cursada
                UpdateCursada();
            }
            else
            {
                MessageBox.Show("El usuario no es un profesor");
            }
        }
        private void ShowStudent()
        {
            ListViewItem item = new ListViewItem();
            Course course = new Course();
            lvCursada.Items.Clear();
            foreach (Cursada cur in listCursada)
            {
                listStudent = teacherService.GetStudentList(cur.IdCursada);
                course = teacherService.GetCourse(cur.IdCourse);
                foreach (Student student in listStudent)
                {
                    //item = lvCursada.Items.Add(student.Name.ToString());
                    item.SubItems.Add(student.Surname);
                    item.SubItems.Add(course.Instrument);
                    item.SubItems.Add(cur.StarTime.ToString("HH:mm") + " a " + cur.EndTime.ToString("HH:mm"));
                }
            }
        }
        // Botones
        private void btnSalir_Click(object sender, EventArgs e)
        {
            CloseSessión();
        }
        private void btnMostrar_Click_1(object sender, EventArgs e)
        {

            ShowStudent();

        }
        private void btnNotificacion_Click(object sender, EventArgs e)
        {
            try
            {

                viewNotification();
                //notification.ShowNotifTeacher(teacher.IdTeacher, teacherService.GetStudentList(cursada.IdCursada));
                notification.Show();
            }
            catch (System.ObjectDisposedException)
            {

                MessageBox.Show("No se puede abrir más de una ventana", "Error de instanciación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnForo_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboCursada.SelectedValue == null)
                {
                    MessageBox.Show("No seleccionaste ninguna cursada");
                }
                else
                {
                    selectValue = int.Parse(comboCursada.SelectedValue.ToString());
                    viewTablon();
                    formTablon.SessionTablon(userSession, selectValue, "Teacher");
                    formTablon.Show();
                }
            }
            catch (System.ObjectDisposedException)
            {

                MessageBox.Show("No se puede abrir más de una ventana", "Error de instanciación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // MenuItem
        private void modificarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                viewUpdate();
                updateTeacher.SetUsers(userSession);
                updateTeacher.SetTeacher(teacher);
                updateTeacher.Show();
            }
            catch (System.ObjectDisposedException)
            {

                MessageBox.Show("No se puede abrir más de una ventana", "Error de instanciación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cerrarSessiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void notificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                viewNotification();
                notification.ShowNotifTeacher(teacher.IdTeacher, listStudent);
                notification.Show();
            }
            catch (System.ObjectDisposedException)
            {

                MessageBox.Show("No se puede abrir más de una ventana", "Error de instanciación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void acercaDeLaSchoolMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("School Music EmBenSeMa version 2.1");
        }
        private void foroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                viewTablon();
                formTablon.Show();
            }
            catch (System.ObjectDisposedException)
            {

                MessageBox.Show("No se puede abrir más de una ventana", "Error de instanciación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Método de intancia de FormNotification
        private void viewNotification()
        {
            // Verifica si ya existe una instancia del formulario
            if (notification == null || notification.IsDisposed)
            {
                // Si no existe, crea una nueva instancia
                notification = new FormNotification();
            }

            // Verifica si el formulario está visible
            if (notification.Visible)
            {
                // Si está visible, cierra la instancia existente
                notification.Close();
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
        private void viewUpdate()
        {
            // Verifica si ya existe una instancia del formulario
            if (updateTeacher == null || updateTeacher.IsDisposed)
            {
                // Si no existe, crea una nueva instancia
                updateTeacher = new FormUpdate();
            }

            // Verifica si el formulario está visible
            if (updateTeacher.Visible)
            {
                // Si está visible, cierra la instancia existente
                updateTeacher.Close();
            }

            // Muestra el formulario actual
            this.Visible = true;
        }
        private void viewTablon()
        {
            // Verifica si ya existe una instancia del formulario
            if (formTablon == null || formTablon.IsDisposed)
            {
                // Si no existe, crea una nueva instancia
                formTablon = new FormTablon();
            }

            // Verifica si el formulario está visible
            if (formTablon.Visible)
            {
                // Si está visible, cierra la instancia existente
                formTablon.Close();
            }

            // Muestra el formulario actual
            this.Visible = true;
        }
        // Botón Cursada
        private void button1_Click(object sender, EventArgs e)
        {
            if (grBoxCursada.Visible == false)
            {
                grBoxCursada.Visible = true;
            }
            else
            {
                grBoxCursada.Visible = false;
            }

            // Limpio los campos
            TextClear();

            // Declaro una lista de Cursos
            List<Course> listCourse = new List<Course>();

            // Cargamos los cursos
            listCourse = teacherService.GetListCourse();
            comboCourse.DataSource = null;
            comboCourse.DataSource = listCourse;
            comboCourse.DisplayMember = "Instrument";
            comboCourse.ValueMember = "IdCourse";

        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Declaramos una instancia de cursada null
            Cursada cursada = new Cursada();

            // Nueva Cursada del profesor
            cursada.IdCourse = int.Parse(comboCourse.SelectedValue.ToString());
            cursada.Initiation = dateInitiation.Value;
            cursada.Finish = dateFinish.Value;
            cursada.IdTeacher = teacher.IdTeacher;
            cursada.StarTime = dateStart.Value;
            cursada.EndTime = dateEnd.Value;
            cursada.Days = txtDia.Text;
            cursada.Description = txtDescription.Text;
            if (int.TryParse(txtVacantes.Text.ToString(), out int numVacan))
            {
                cursada.Vacantes = numVacan;
            }
            if (float.TryParse(txtCuota.Text.ToString(), out float numFee))
            {
                cursada.PayFee = numFee;
            }

            // Valida los datos de la cursada
            if (teacherService.ValidaCursada(cursada))
            {
                // Agrega la cursada a la BD
                if (teacherService.AddCursada(cursada))
                {

                    UpdateCursada();
                    foreach (Cursada cr in listCursada)
                    {
                        if (cr.Description == cursada.Description)
                        {
                            teacherService.AddTablon(cr.IdCursada.ToString());
                        }
                    }
                    ShowStudent();
                }

                grBoxCursada.Visible = false;
            }
            else
            {
                MessageBox.Show("Se encontrarón errores. Revisa los datos de la cursada.");
                cursada = null;
            }
        }
        private void TextClear()
        {
            txtDia.Text = "";
            txtDescription.Text = "";
            txtCuota.Text = "";
            txtVacantes.Text = "";
        }
        // Cerrar Sessión
        private void CloseSessión()
        {
            DialogResult resut = MessageBox.Show("Si vas a salir se cierra la sessión ¿Queres cerrar la sessión? ", "Cerrar Sessión", MessageBoxButtons.YesNo);
            if (resut == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void UpdateCursada()
        {
            listCursada = teacherService.GetCursadaList(teacher.IdTeacher);
            if (listCursada != null)
            {
                comboCursada.DataSource = null;
                comboCursada.DataSource = listCursada;
                comboCursada.DisplayMember = "IdCursada";
                comboCursada.ValueMember = "IdCursada";
                comboCursada.SelectedIndex = -1;
                btnForo.Enabled = true;
            }
        }
    }
}
