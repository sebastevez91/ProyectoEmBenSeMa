using SchoolMusic.Entidades;
using SchoolMusic.Serv;

namespace SchoolMusic.Proyecto
{
    public partial class FormTablon : Form
    {
        public FormTablon()
        {
            InitializeComponent();
        }
        private TablonService tablonService = new TablonService();
        private Cursada cursada = new Cursada();
        private Users userSession = new Users();
        private List<Topic> topics = new List<Topic>();
        private List<Coment> coments = new List<Coment>();
        private string itemElegido = "";

        public void SesionTablon(Users user, int idCursada)
        {
            // Usuario en sesión
            userSession = user;
            // Cursada en sesión
            cursada = tablonService.GetCursada(idCursada);
            // Titulo
            tittle.Text = $"Cursada de {tablonService.GetNameCourse(cursada.IdCourse)}, de {cursada.StarTime.ToString("HH:mm")} a {cursada.EndTime.ToString("HH:mm")}";
            profesor.Text = $"Profesor {tablonService.GetNameTeacher(cursada.IdTeacher)}";
            // Indico el tipo de usuario
            if (user.Rol == "Alumno")
            {
                grBoxAnuncio.Enabled = false;
            }

            // Limpio la lista de topics
            topics.Clear();

            // Lista de topics
            UpdateListBox(idCursada);
        }
        // Botones
        private void button1_Click(object sender, EventArgs e)
        {
            // Instanciamos un nuevo topic
            Topic topic = new Topic();

            // Botón Publicar anuncio
            if (txtTitulo.Text != string.Empty && txtAnuncio.Text != string.Empty)
            {
                // Asignamos los valores a un nuevo topic
                topic.Title = txtTitulo.Text;
                topic.Content = txtAnuncio.Text;
                topic.IdCursada = cursada.IdCursada;

                // Cargo el nuevo topic a la base de datos
                if (!tablonService.SetTopic(topic))
                {
                    MessageBox.Show("No se pudo publicar el nuevo anuncio");
                }

                // Limpio el listbox de topics
                listTopic.DataSource = null;

                // Actualizo el listBox de topics
                UpdateListBox(topic.IdCursada);
            }
            else
            {
                MessageBox.Show("No se ha ingresado ningún anuncio.");
            }
            // Limpio los campos
            txtAnuncio.Text = string.Empty;
            txtTitulo.Text = string.Empty;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // Instanciamos un nuevo comentario
            Coment coment = new Coment();
            // Botón Publicar comentario
            if (txtComentario.Text != string.Empty)
            {
                // Asignamos los nuevos valores al nuevo comentario
                coment.Content = txtComentario.Text;
                coment.IdTopic = int.Parse(listTopic.SelectedValue.ToString());
                coment.Author = tablonService.GetNameUser(userSession);

                // Cargo el nuevo comentario a la base de datos
                if (!tablonService.SetComent(coment))
                {
                    MessageBox.Show("No se pudo comentar la publicación");
                }

                // Actualizo el TreeView con el nuevo comentario
                UpdateTreeView(listTopic.SelectedValue.ToString());

                // Limpio el campo de comentario
                txtComentario.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("No se ha ingresado nigún comenntario");
            }

        }
        private void UpdateTreeView(string id)
        {
            try
            {
                // Almaceno id del topic elegido
                itemElegido = id;

                // Obtener la lista de temas
                coments = tablonService.GetListComent(id);

                // Limpiar el TreeView
                trViewComent.Nodes.Clear();

                // Motramos los comentarios
                foreach (Coment com in coments)
                {
                    // Agregar al nodo de comentario
                    TreeNode comentNodo = new TreeNode($"***{com.Author}***  Fecha : {com.DateComent}");
                    trViewComent.Nodes.Add(comentNodo);
                    comentNodo.Nodes.Add(com.Content);
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones (por ejemplo, registrar o mostrar un mensaje de error)
                Console.WriteLine($"Error al actualizar los comentarios: {ex.Message}");
            }
        }
        private void UpdateListBox(int id)
        {
            listTopic.DataSource = tablonService.GetListTopic(id);
            listTopic.DisplayMember = "Title";
            listTopic.ValueMember = "IdTopic";
            listTopic.SelectedIndex = -1;

        }
        private void listTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTopic.SelectedIndex >= 0)
            {
                // Cargo comentarios
                foreach (Topic top in topics)
                {
                    if (top.IdTopic.ToString() == listTopic.SelectedValue.ToString())
                    {
                        etqTitulo.Text = top.Title;
                        contenidoAnuncio.Text = top.Content.ToString();
                        UpdateTreeView(top.IdTopic.ToString());
                    }
                }
            }
        }
    }
}
