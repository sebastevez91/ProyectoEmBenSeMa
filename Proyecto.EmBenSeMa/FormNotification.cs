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
        NotificationService notificationService = new NotificationService();
        List<Notification> listRecibidos = new List<Notification>();
        List<Notification> listEnvios = new List<Notification>();
        Notification notification = new Notification();

        private int idUserSesion;
        private int idUserTo;

        public void ShowNotification(int idUser)
        {
            idUserSesion = idUser;
            listRecibidos.Clear();
            listRecibidos = notificationService.GetNotificationRecibidas(idUserSesion);
            listEnvios.Clear();
            listEnvios = notificationService.GetNotificationEnviadas(idUserSesion);
        }
        private void MostrarSubject()
        {

            Recpcion.DataSource = null;
            Recpcion.DataSource = listRecibidos;
            Recpcion.DisplayMember = "Subject";
            Recpcion.ValueMember = "IdNotification";
            Recpcion.SelectedIndex = -1;

            Enviados.DataSource = null;
            Enviados.DataSource = listEnvios;
            Enviados.DisplayMember = "Subject";
            Enviados.ValueMember = "IdNotification";
            Enviados.SelectedIndex = -1;

        }
        // Botones
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnResponde_Click(object sender, EventArgs e)
        {
            grboxMensaje.Visible = false;
            txtAsunto.Visible = false;
            groupBoxSend.Visible = true;
            btnEnviar.Visible = true;
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (groupBoxSend.Visible == true)
            {
                grboxMensaje.Visible = true;
                groupBoxSend.Visible = false;
                btnEnviar.Visible = false;
            }
            if (Recpcion.Visible == true)
            {
                btnResponde.Visible = true;
                foreach (Notification n in listRecibidos)
                {
                    if (Recpcion.SelectedValue?.ToString() == n.IdNotification.ToString())
                    {
                        etqMensaje.Text = "Fecha del mensaje: " + n.DateNotification + "\n" +
                            "Mensaje: " + n.Body;
                        idUserTo = n.NotificationFrom;
                    }
                }
            }
            else
            {
                btnResponde.Visible = false;
                foreach (Notification n in listEnvios)
                {
                    if (Enviados.SelectedValue?.ToString() == n.IdNotification.ToString())
                    {
                        etqMensaje.Text = "Fecha del mensaje: " + n.DateNotification + "\n" +
                            "Mensaje: " + n.Body;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            grboxMensaje.Visible = false;
            etqMensaje.Text = "";
            groupBoxSend.Visible = true;
            btnEnviar.Visible = true;
            btnResponde.Visible = false;
            etqSubject.Text = "Asunto: ";
            etqTo.Text = "Para: ";
            txtAsunto.Clear();
            txtAsunto.Visible = true;
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int result;

            if (txtAsunto.Text != " " && txtMensaje.Text != " ")
            {
                notification.NotificationTo = idUserTo;
                notification.NotificationFrom = idUserSesion;
                notification.Subject = txtAsunto.Text;
                notification.Body = txtMensaje.Text;
                result = notificationService.SendNotification(notification);

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
            Recpcion.DataSource = null;
            ShowNotification();
            MostrarSubject();
            Enviados.Visible = false;
            Recpcion.Visible = true;
        }
        private void btnEnviados_Click(object sender, EventArgs e)
        {
            TypeMjs.Text = "Mensajes Enviados";
            ShowNotification();
            Enviados.DataSource = null;
            Enviados.Items.Clear();
            MostrarSubject();
            Recpcion.Visible = false;
            Enviados.Visible = true;
        }
    }
}
