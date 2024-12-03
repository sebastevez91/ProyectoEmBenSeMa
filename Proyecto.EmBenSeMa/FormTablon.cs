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
        private Tablon tablon = new Tablon();
        private Cursada cursada = new Cursada();
        private Users userSession = new Users();
        private List<Topic> topics = new List<Topic>();
        private List<Coment> coments = new List<Coment>();
        private string itemElegido = "";
        private string tipo = "";

        public void SesionTablon(Users user, int idCursada, string tipoUser)
        {
            // Usuario en sesión
            userSession = user;
            // Cursada en sesión
            cursada = tablonService.GetCursada(idCursada);
            // Titulo
            tittle.Text = $"Cursada de {tablonService.GetNameCourse(cursada.IdCourse)}, de {cursada.StarTime.ToString("HH:mm")} a {cursada.EndTime.ToString("HH:mm")}";
            profesor.Text = $"Profesor {tablonService.GetNameTeacher(cursada.IdTeacher)}";
            // Indico el tipo de usuario
            tipo = tipoUser;
            if (tipo == "Student")
            {
                btnEliminar.Visible = true;
                grBoxAnuncio.Enabled = false;
            }
            else
            {
                btnEliminar.Visible = false;
                grBoxAnuncio.Enabled = true;
            }
            // Tablón en sesión, según cursada
            tablon = tablonService.GetTablon(idCursada.ToString());
            // Limpio la lista de topics
            topics.Clear();
            // Cargo la lista de topics
            if (tablon != null)
            {
                topics = tablonService.GetListTopic(tablon.idTablon);
                // Actualizo el listBox que contiene los topics
                UpdateListBox();
            }
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
                //topic.title = txtTitulo.Text;
                //topic.asunto = txtAnuncio.Text;
                //topic.idTablon = tablon.idTablon;
                // Cargo el nuevo topic a la base de datos
                tablonService.SetTopic(topic);
                // Limpio el listbox de topics
                listTopic.DataSource = null;
                // Actualizo el listBox de topics
                UpdateListBox();
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
                //coment.comentDesc = txtComentario.Text;
                //coment.idTopic = int.Parse(itemElegido);
                //coment.nameUser = tablonService.GetNameUser(userSession.IdUser,tipo);
                // Cargo el nuevo comentario a la base de datos
                tablonService.SetComent(coment);
                // Actualizo el TreeView con el nuevo comentario
                UpdateTreeView(itemElegido);
                // Limpio el campo de comentario
                txtComentario.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("No se ha ingresado nigún comenntario");
            }

        }
        private void UpdateTreeView(string idTopic)
        {
            try
            {
                itemElegido = idTopic;
                // Obtener la lista de temas
                coments = tablonService.GetListComent(idTopic);

                // Limpiar el TreeView
                trViewComent.Nodes.Clear();

                // Motramos los comentarios
                foreach (Coment com in coments)
                {
                    // Agregar al nodo de comentario
                    //TreeNode comentNodo = new TreeNode($"***{com.nameUser}***  Fecha : {com.dateComent}");
                    //trViewComent.Nodes.Add(comentNodo);
                    //comentNodo.Nodes.Add(com.comentDesc);
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones (por ejemplo, registrar o mostrar un mensaje de error)
                Console.WriteLine($"Error al actualizar los comentarios: {ex.Message}");
            }
        }
        private void UpdateListBox()
        {
            listTopic.DataSource = tablonService.GetListTopic(tablon.idTablon);
            listTopic.DisplayMember = "title";
            listTopic.ValueMember = "IdTopic";
            listTopic.SelectedIndex = -1;

        }
        private void listTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTopic.SelectedIndex >= 0)
            {

                foreach (Topic top in topics)
                {
                    //if (top.idTopic.ToString() == listTopic.SelectedValue.ToString())
                    //{
                    //    etqTitulo.Text = top.title;
                    //    contenidoAnuncio.Text = top.asunto.ToString();
                    //    UpdateTreeView(top.idTopic.ToString());
                    //}
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listTopic.SelectedItems.Count >= 0)
            {
                foreach (Topic top in topics)
                {
                    //if (top.idTopic == int.Parse(listTopic.SelectedValue.ToString()))
                    //{
                    //    tablonService.DeleteTopic(top.idTopic);
                    //}
                }
                UpdateListBox();
            }
        }
    }
}
