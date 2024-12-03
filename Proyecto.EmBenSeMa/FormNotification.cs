using SchoolMusic.Entidades;
using SchoolMusic.Serv;

namespace SchoolMusic.Proyecto
{
    public partial class FormNotification : Form
    {
        private readonly NotificationService _notificationService;
        private List<Notification> _listRecibidos;
        private List<Notification> _listEnvios;
        private int _idUserSesion;

        public FormNotification()
        {
            InitializeComponent();
            _notificationService = new NotificationService();
            _listRecibidos = new List<Notification>();
            _listEnvios = new List<Notification>();
        }

        // Mostrar notificaciones generales
        private void CargarNotificaciones(List<Notification> lista, string tipoMensaje)
        {
            // Oculto el grupo detalles
            grBoxDetalles.Visible = false;

            TypeMjs.Text = tipoMensaje;

            // Limpio completamente el ListBox
            listMensaje.DataSource = null;
            listMensaje.Items.Clear();

            // Asigno nuevos datos si la lista tiene elementos
            if (lista.Any())
            {
                listMensaje.DataSource = lista;
                listMensaje.DisplayMember = "Subject";
                listMensaje.ValueMember = "IdNotification";
                listMensaje.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("No hay mensajes disponibles", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ShowNotification(int idUser)
        {
            _idUserSesion = idUser;
            _listRecibidos = _notificationService.GetNotificationRecibidas(_idUserSesion);
            CargarNotificaciones(_listRecibidos, "Mensajes Recibidos");
        }

        private void btnRecpcion_Click(object sender, EventArgs e)
        {
            _listRecibidos.Clear();
            _listRecibidos = _notificationService.GetNotificationRecibidas(_idUserSesion);
            CargarNotificaciones(_listRecibidos, "Mensajes Recibidos");
        }

        private void btnEnviados_Click(object sender, EventArgs e)
        {
            _listEnvios.Clear();
            _listEnvios = _notificationService.GetNotificationEnviadas(_idUserSesion);
            CargarNotificaciones(_listEnvios, "Mensajes Enviados");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listMensaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Muestro grupo detalles
            grBoxDetalles.Visible = true;

            // Verifica que haya un elemento seleccionado y un tipo definido
            if (listMensaje.SelectedValue == null || string.IsNullOrEmpty(TypeMjs.Text))
                return;

            // Obtén el ID seleccionado
            int idSeleccionado;
            if (!int.TryParse(listMensaje.SelectedValue.ToString(), out idSeleccionado))
                return;

            // Determina la lista correspondiente según el tipo de mensaje
            List<Notification> listaActual = TypeMjs.Text == "Mensajes Recibidos" ? _listRecibidos : _listEnvios;

            // Busca el mensaje seleccionado en la lista
            var mensajeSeleccionado = listaActual.FirstOrDefault(m => m.IdNotification == idSeleccionado);

            if (mensajeSeleccionado != null)
            {
                // Muestra los detalles del mensaje
                txtSubjet.Text = mensajeSeleccionado.Subject;
                txtMensaje.Text = mensajeSeleccionado.Body;
            }
        }
    }

}
