using Proyecto.EmBenSeMa;
using SchoolMusic.Entidades;
using SchoolMusic.Serv;

namespace SchoolMusic.Proyecto
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }
        // Declaración de variables globales
        private int idCursada;
        private Users userSesion = null;
        private Student student = new Student();
        private Teacher teacher = new Teacher();
        private StudentsService studentsService = new StudentsService();
        private FormUpdate updateStudent = new FormUpdate();
        private FormNotification notification;
        private FormContact formContact;
        private FormPayment payment;
        private FormCourse formCursos;
        private FormTablon formTablon;
        List<Cursada> listCursada = new List<Cursada>();
        List<Course> listCourse = new List<Course>();
        ListViewItem item = new ListViewItem();
        // Muestra de Datos y Curso
        private void CourseDate()
        {
            listCourse.Clear();
            foreach (Cursada cursoStudent in listCursada)
            {
                listCourse.Add(studentsService.GetCourse(cursoStudent.IdCourse));
            }
        }
        private void ShowInfo()
        {
            string completoName = "";
            Course course = null;
            lvCursos.Items.Clear();
            if(listCursada.Count <= 0)
            {
                btnCanceCurs.Enabled = false;
                btnTablon.Enabled = false;
                btnPay.Enabled = false;
                pagosToolStripMenuItem.Enabled = false;
                foroToolStripMenuItem.Enabled = false;
            }
            foreach (Cursada c in listCursada)
            {
                course = studentsService.GetCourse(c.IdCourse);
                teacher = studentsService.GetTeacher(c.IdTeacher);
                completoName = teacher.NameTeacher + " " + teacher.Surname;
                item = lvCursos.Items.Add(c.IdCursada.ToString());
                item.SubItems.Add(completoName);
                item.SubItems.Add(course.Instrument);
                item.SubItems.Add(c.StarTime.ToString());
                item.SubItems.Add(c.EndTime.ToString());
            }
            CourseDate();
        }
        public void ShowData(Users userSesion)
        {
            this.userSesion = userSesion;
            student = studentsService.GetStudent(userSesion.IdUser);

            if (student != null)
            {
                //Datos Personales
                etqData.Text = $"NOMBRE COMPLETO: {student.NameStudent} {student.Surname}\n" +
                    $"DNI: {student.Dni}  EDAD: {student.Age}\n" +
                    $"CORREO: {student.Mail}\n";

                // Traemos las cursadas a las que está inscripto
                listCursada = studentsService.GetListCursada(student.IdStudent);
                CourseDate();
            }
            else
            {
                this.Close();
                MessageBox.Show("El usuario no es un alumno");
            }

        }
        // Botones
        private void btnSalir_Click(object sender, EventArgs e)
        {
            CloseSessión();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                viewCourse();
                formCursos.StudentCourse(student);
                formCursos.Show();
            }
            catch (System.ObjectDisposedException)
            {

                MessageBox.Show("No se puede abrir más de una ventana", "Error de instanciación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNotificacion_Click(object sender, EventArgs e)
        {
            try
            {
                viewNotification();
                notification.ShowNotification(userSesion.IdUser);
                notification.Show();
            }
            catch (System.ObjectDisposedException)
            {

                MessageBox.Show("No se puede abrir más de una ventana", "Error de instanciación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                viewPayment();
                payment.ShowPaymentStudent(student, "Student");
                payment.Show();
            }
            catch (System.ObjectDisposedException)
            {

                MessageBox.Show("No se puede abrir más de una ventana", "Error de instanciación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            student = studentsService.GetStudent(userSesion.IdUser);
            listCursada = studentsService.GetListCursada(student.IdStudent);
            if (listCursada.Count <= 0)
            {
                MessageBox.Show("No te has inscripto a ninguna cursada");
            }
            ShowInfo();
        }
        private void btnForo_Click(object sender, EventArgs e)
        {
            try
            {
                viewTablon();
                formTablon.SessionTablon(userSesion, idCursada, "Student");
                formTablon.Show();
            }
            catch (System.ObjectDisposedException)
            {

                MessageBox.Show("No se puede abrir más de una ventana", "Error de instanciación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Menú strip
        private void cerrarSessiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseSessión();
        }
        private void modificarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                viewUpdate();
                updateStudent.SetUsers(userSesion);
                updateStudent.SetStudent(student);
                updateStudent.Show();
            }
            catch (System.ObjectDisposedException)
            {

                MessageBox.Show("No se puede abrir más de una ventana", "Error de instanciación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cerrarSecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                viewNotification();
                notification.ShowNotification(userSesion.IdUser);
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
        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                viewPayment();
                payment.ShowPaymentStudent(student, "Student");
                payment.Show();
            }
            catch (System.ObjectDisposedException)
            {

                MessageBox.Show("No se puede abrir más de una ventana", "Error de instanciación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void foroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                viewTablon();
                formTablon.SessionTablon(userSesion, idCursada, "Student");
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
        private void viewPayment()
        {
            // Verifica si ya existe una instancia del formulario
            if (payment == null || payment.IsDisposed)
            {
                // Si no existe, crea una nueva instancia
                payment = new FormPayment();
            }

            // Verifica si el formulario está visible
            if (payment.Visible)
            {
                // Si está visible, cierra la instancia existente
                payment.Close();
            }

            // Muestra el formulario actual
            this.Visible = true;
        }
        private void viewCourse()
        {
            // Verifica si ya existe una instancia del formulario
            if (formCursos == null || formCursos.IsDisposed)
            {
                // Si no existe, crea una nueva instancia
                formCursos = new FormCourse();
            }

            // Verifica si el formulario está visible
            if (formCursos.Visible)
            {
                // Si está visible, cierra la instancia existente
                formCursos.Close();
            }

            // Muestra el formulario actual
            this.Visible = true;
        }
        private void viewUpdate()
        {
            // Verifica si ya existe una instancia del formulario
            if (updateStudent == null || updateStudent.IsDisposed)
            {
                // Si no existe, crea una nueva instancia
                updateStudent = new FormUpdate();
            }

            // Verifica si el formulario está visible
            if (updateStudent.Visible)
            {
                // Si está visible, cierra la instancia existente
                updateStudent.Close();
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
        // Cerrar Sessión
        private void CloseSessión()
        {
            DialogResult resut = MessageBox.Show("Si vas a salir se cierra la sessión ¿Queres cerrar la sessión? ", "Cerrar Sessión", MessageBoxButtons.YesNo);
            if (resut == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void lvCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCursos.SelectedItems.Count > 0)
            {
                var selectedItem = int.Parse(lvCursos.SelectedItems[0].Text);

                if (selectedItem != null)
                {
                    foreach (Cursada cur in listCursada)
                    {
                        if (selectedItem == cur.IdCursada)
                        {
                            idCursada = cur.IdCursada;
                            btnTablon.Enabled = true;
                            btnCanceCurs.Enabled = true;
                            btnPay.Enabled = true;
                            pagosToolStripMenuItem.Enabled = true;
                            foroToolStripMenuItem.Enabled = true;
                            break; // Salir del bucle una vez encontrado el elemento
                        }
                    }
                }
            }
        }
        private void btnCanceCurs_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Queres cancelar la cursada?", "Cancelación de cursada", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if(studentsService.DeleteInscription(idCursada, student.IdStudent))
                {
                    MessageBox.Show("Inscripción a cursada cancelada");
                }
                else
                {
                    MessageBox.Show("No se pudo cancelar la cursada");
                }
            }
                

            listCursada = studentsService.GetListCursada(student.IdStudent);
            idCursada = 0;
            ShowInfo();
        }
    }
}
