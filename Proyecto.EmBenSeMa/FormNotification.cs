using SchoolMusic.Entidades;
using SchoolMusic.Serv;

namespace SchoolMusic.Proyecto
{
    public partial class FormNotification : Form
    {
        public FormNotification()
        {
            InitializeComponent();
        }
        NotificationService notifService = new NotificationService();
        List<Notification> listSubject = new List<Notification>();
        List<Teacher> listTeacher = new List<Teacher>();
        List<Student> listStudent = new List<Student>();
        Notification notification = new Notification();

        private int idFound = 0;
        private string selectedValue;
        private string tipoUser = "";
        public void ShowNotifStudent(int numId, List<Cursada> listCursada)
        {
            tipoUser = "Student";

            idFound = numId;
            foreach (Cursada c in listCursada)
            {
                listTeacher.Add(notifService.GetTeacher(c.IdTeacher));
            }
            UpdateSubject(numId);
            MostrarSubject();
        }
        public void ShowNotifTeacher(int numId, List<Student> listStudent)
        {
            tipoUser = "Teacher";

            idFound = numId;
            foreach (Student s in listStudent)
            {
                this.listStudent.Add(notifService.GetStudent(s.IdStudent));
            }
            UpdateSubject(numId);
            MostrarSubject();
        }
        private void MostrarSubject()
        {
            List<Notification> listRecibidos = new List<Notification>();
            List<Notification> listEnvio = new List<Notification>();
            listRecibidos.Clear();
            listEnvio.Clear();
            foreach (Notification n in listSubject)
            {
                if (n.tipo == "Recepción")
                {
                    listRecibidos.Add(n);
                }
                else
                {
                    listEnvio.Add(n);
                }
            }
            listRecpcion.DataSource = null;
            listRecpcion.DataSource = listRecibidos;
            listRecpcion.DisplayMember = "Subject";
            listRecpcion.ValueMember = "IdNotification";
            listRecpcion.SelectedIndex = -1;

            listEnviados.DataSource = null;
            listEnviados.DataSource = listEnvio;
            listEnviados.DisplayMember = "Subject";
            listEnviados.ValueMember = "IdNotification";
            listEnviados.SelectedIndex = -1;

        }
        private void MostrarTeacher()
        {
            comboTo.DataSource = null;
            comboTo.DataSource = listTeacher;
            comboTo.DisplayMember = "Name";
            comboTo.ValueMember = "IdTeacher";
            comboTo.SelectedIndex = -1;
        }
        private void MostrarStudent()
        {
            comboTo.DataSource = null;
            comboTo.DataSource = listStudent;
            comboTo.DisplayMember = "Name";
            comboTo.ValueMember = "IdStudent";
            comboTo.SelectedIndex = -1;
        }
        // Botones
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnResponde_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            Teacher teacher = new Teacher();
            grboxMensaje.Visible = false;
            comboTo.Visible = false;
            txtAsunto.Visible = false;
            groupBoxSend.Visible = true;
            btnEnviar.Visible = true;
            foreach (Notification n in listSubject)
            {
                if (n.idNotification == int.Parse(selectedValue))
                {
                    etqSubject.Text = $"Asunto: {n.subject}";
                    if (tipoUser == "Student")
                    {
                        teacher = notifService.GetTeacher(n.idTeacher);
                        etqTo.Text = $"Para: {teacher.NameTeacher}";
                    }
                    else
                    {
                        student = notifService.GetStudent(n.idStudent);
                        etqTo.Text = $"Para: {student.Name}";
                    }
                    txtAsunto.Text = n.subject;
                }
            }
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (groupBoxSend.Visible == true)
            {
                grboxMensaje.Visible = true;
                groupBoxSend.Visible = false;
                btnEnviar.Visible = false;
            }


            if (TypeMjs.Text == "Mensajes Recibidos")
            {
                selectedValue = listRecpcion.SelectedValue?.ToString();
                btnResponde.Visible = true;
            }
            else
            {
                selectedValue = listEnviados.SelectedValue?.ToString();
                btnResponde.Visible = false;
            }

            // Esta línea de código verifica si la variable selectedValue no es nula ni está vacía.
            // Si es así, el resultado será true; de lo contrario, será false.
            if (!string.IsNullOrEmpty(selectedValue))
            {
                if (groupBoxSend.Visible == true)
                {
                    grboxMensaje.Visible = true;
                    groupBoxSend.Visible = false;
                }
                if (listSubject != null && listSubject.Count > 0)
                {
                    etqMensaje.Visible = true;
                    foreach (Notification n in listSubject)
                    {
                        if (selectedValue == n.idNotification.ToString())
                        {
                            etqMensaje.Text = "Fecha del mensaje: " + n.dateNotification + "\n" +
                                "Mensaje: " + n.body;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se a seleccionado ningún mensaje.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            grboxMensaje.Visible = false;
            etqMensaje.Text = "";
            groupBoxSend.Visible = true;
            btnEnviar.Visible = true;
            btnResponde.Visible = false;
            comboTo.Visible = true;
            etqSubject.Text = "Asunto: ";
            etqTo.Text = "Para: ";
            txtAsunto.Clear();
            txtAsunto.Visible = true;
            if (tipoUser == "Student")
            {
                MostrarTeacher();
            }
            else
            {
                MostrarStudent();
            }
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            Teacher teacher = new Teacher();
            string name = "";
            if (txtAsunto.Text != " " && txtMensaje.Text != " ")
            {
                if (tipoUser == "Student")
                {
                    if (idFound > 0)
                    {
                        if (comboTo.Visible == true)
                        {
                            selectedValue = comboTo.SelectedValue.ToString();
                            foreach (Teacher t in listTeacher)
                            {
                                if(t.IdTeacher == int.Parse(selectedValue))
                                {
                                    name = t.NameTeacher;
                                }
                            }
                        }
                        else
                        {
                            foreach (Notification n in listSubject)
                            {
                                if (n.idNotification == int.Parse(selectedValue))
                                {
                                    foreach (Teacher t in listTeacher)
                                    {
                                        if (t.IdTeacher == n.idTeacher)
                                        {
                                            name = t.NameTeacher;
                                            selectedValue = t.IdTeacher.ToString();
                                        }
                                    }
                                }
                            }
                        }

                        student = notifService.GetStudent(idFound);
                        notification.idStudent = student.IdStudent;
                        notification.idTeacher = int.Parse(selectedValue);
                        notification.subject = txtAsunto.Text;
                        notification.body = txtMensaje.Text + "\n" +
                            $"Para: {name} \n" +
                            $"Enviado por: {student.Name}";
                        notifService.SendNotifiStudent(notification);
                    }
                }
                else
                {
                    if (idFound > 0 && tipoUser == "Teacher")
                    {
                        if (comboTo.Visible == true)
                        {
                            selectedValue = comboTo.SelectedValue.ToString();
                            foreach (Student s in listStudent)
                            {
                                if (s.IdStudent == int.Parse(selectedValue))
                                {
                                    name = s.Name;
                                }
                            }
                        }
                        else
                        {
                            foreach (Notification n in listSubject)
                            {
                                if (n.idNotification == int.Parse(selectedValue))
                                {
                                    foreach (Student s in listStudent)
                                    {
                                        if (s.IdStudent == n.idStudent)
                                        {
                                            name = s.Name;
                                        }
                                    }
                                    selectedValue = n.idStudent.ToString();
                                }
                            }
                        }

                        teacher = notifService.GetTeacher(idFound);
                        notification.idStudent = int.Parse(selectedValue);
                        notification.idTeacher = teacher.IdTeacher;
                        notification.subject = txtAsunto.Text;
                        notification.body = txtMensaje.Text + "\n" +
                            $"Para: {name}\n" +
                            $"Enviado por: {teacher.NameTeacher}";
                        notifService.SendNotifiTeacher(notification);
                    }
                }
            }
            else
            {
                txtAsunto.PlaceholderText = "Debes completar este campo";
                txtAsunto.BackColor = Color.IndianRed;
            }

            txtAsunto.Text = "";
            txtMensaje.Text = "";
            groupBoxSend.Visible = false;
            btnResponde.Visible = false;
            btnEnviar.Visible = false;
            grboxMensaje.Visible = true;
        }
        private void btnRecpcion_Click(object sender, EventArgs e)
        {
            TypeMjs.Text = "Mensajes Recibidos";
            listRecpcion.DataSource = null;
            UpdateSubject(idFound);
            MostrarSubject();
            listEnviados.Visible = false;
            listRecpcion.Visible = true;
        }
        private void btnEnviados_Click(object sender, EventArgs e)
        {
            TypeMjs.Text = "Mensajes Enviados";
            listEnviados.DataSource = null;
            listEnviados.Items.Clear();
            UpdateSubject(idFound);
            MostrarSubject();
            listRecpcion.Visible = false;
            listEnviados.Visible = true;
        }
        private void UpdateSubject(int numId)
        {
            listSubject.Clear();
            if (tipoUser == "Student")
            {
                listSubject = notifService.GetNotificationStudent(numId);
            }
            else
            {
                listSubject = notifService.GetNotificationTeacher(numId);
            }
        }
    }
}
