using Capa.Base.De.Datos;
using SchoolMusic.BD;
using SchoolMusic.Entidades;
using System.Data;

namespace SchoolMusic.Serv
{
    public class TablonService
    {
        Dictionary<string, string> prm = new Dictionary<string, string>();
        private CnxSelect select = new CnxSelect();
        private CnxAccion accion = new CnxAccion();
        List<Topic> listTopic = new List<Topic>();
        public Tablon GetTablon(string idCursada)
        {
            Tablon tablon = null;

            // Agrego parámetros 
            prm.Clear();
            prm.Add("@idCursada", idCursada);

            // Query
            string sqlSelectTablon = "SELECT * FROM Tablon WHERE IdCursada = @idCursada";
            try
            {
                var dataTablon = select.SelectData(sqlSelectTablon, prm);
                if (dataTablon.Rows.Count > 0)
                {
                    var table = dataTablon.Rows[0];
                    tablon = new Tablon()
                    {
                        idTablon = int.Parse(table["IdTablon"].ToString()),
                        idCursada = int.Parse(table["IdCursada"].ToString())
                    };
                }

            }
            catch (Exception e)
            {

               Console.WriteLine("Error: " + e.Message);
            }
            return tablon;
        }
        public List<Topic> GetListTopic(int idTablon)
        {
            // Agrego los parámetros
            listTopic.Clear();
            prm.Clear();
            prm.Add("@idTablon", idTablon.ToString());

            // Query
            string sqlSelectTopic = "SELECT * FROM Topic WHERE IdTablon = @idTablon";
            var dataTopic = select.SelectData(sqlSelectTopic, prm);

            if (dataTopic != null && dataTopic.Rows.Count > 0)
            {
                foreach (DataRow top in dataTopic.Rows)
                {
                    //listTopic.Add(new Topic()
                    //{
                    //    idTopic = int.Parse(top["IdTopic"].ToString()),
                    //    title = top["Titulo"].ToString(),
                    //    asunto = top["Asunto"].ToString(),
                    //    Datetopic = Convert.ToDateTime(top["DateTopic"].ToString())
                    //});
                }
            }
            return listTopic;
        }
        public void SetTopic(Topic topic)
        {
            // Agrego parámetros
            prm.Clear();
            //prm.Add("@titulo", topic.title);
            //prm.Add("@asunto", topic.asunto);
            //prm.Add("@idTablon", topic.idTablon.ToString());

            // Query
            string sqlInsertTopic = "INSERT INTO Topic (Titulo,DateTopic,IdTablon,Asunto)" +
                "VALUES (@titulo,GETDATE(),@idTablon,@asunto)";
            var result = accion.AccionEjecutar(sqlInsertTopic, prm);
        }
        public List<Coment> GetListComent(string idTopic)
        {
            List<Coment> listComent = new List<Coment>();

            // Agrego parámetros 
            prm.Clear();
            prm.Add("@idTopic", idTopic);

            // Query
            string sqlSelectComent = "SELECT * FROM Comentario WHERE IdTopic = @idTopic";
            var dataComent = select.SelectData(sqlSelectComent, prm);

            if (dataComent != null && dataComent.Rows.Count > 0)
            {
                foreach (DataRow row in dataComent.Rows)
                {
                    //listComent.Add(new Coment()
                    //{
                    //    idComent = int.Parse(row["IdComentario"].ToString()),
                    //    comentDesc = row["MensajeComen"].ToString(),
                    //    dateComent = Convert.ToDateTime(row["DateComentario"].ToString()),
                    //    nameUser = row["NameUser"].ToString()
                    //});
                }
            }
            return listComent;
        }
        public void SetComent(Coment coment)
        {
            int result = 0;
            // Agrego parámetros
            //prm.Clear();
            //prm.Add("@mensajeComen", coment.comentDesc);
            //prm.Add("@nameUser", coment.nameUser);
            //prm.Add("@idTopic", coment.idTopic.ToString());

            // Query
            string sqlInsertComent = "INSERT INTO Comentario (MensajeComen,DateComentario,NameUser,IdTopic)" +
                "VALUES (@mensajeComen,GETDATE(),@nameUser,@idTopic)";
            result = accion.AccionEjecutar(sqlInsertComent, prm);
            if (result < 0 && result == null)
            {
                //MessageBox.Show("Hubo problemas al agregar el comentario");
            }
        }
        public string GetNameUser(int idUser, string tipo)
        {
            string nameUser = "";

            // Agrego parámetros
            prm.Clear();
            prm.Add("@idUser", idUser.ToString());

            // Query
            string sqlSelect = tipo == "Student"
                ? "SELECT CONCAT(NameStudent, ' ', Surname) AS completoName FROM Student WHERE IdUser = @idUser"
                : "SELECT CONCAT('Prof.',NameTeacher, ' ', Surname) AS completoName FROM Teacher WHERE IdUser = @idUser";

            try
            {
                var dataName = select.SelectData(sqlSelect, prm);
                if (dataName.Rows.Count > 0)
                {
                    var table = dataName.Rows[0];
                    nameUser = table["completoName"].ToString(); 
                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción (por ejemplo, registrar el error, devolver un valor por defecto, etc.)
                Console.WriteLine("Error: " + ex.Message);
                nameUser = "Unknown User";
            }

            return nameUser;
        }
        public string GetNameTeacher(int idTeacher)
        {
            string nameTeacher = "";

            // Agrego parámetros
            prm.Clear();
            prm.Add("@idTeacher", idTeacher.ToString());

            try
            {
                // Query
                string sqlSelectNameTeacher = "SELECT CONCAT(NameTeacher,' ',Surname) AS completo FROM Teacher WHERE IdTeacher = @idTeacher";
                var dataNameTeacher = select.SelectData(sqlSelectNameTeacher, prm);

                if (dataNameTeacher.Rows.Count > 0)
                {
                    var table = dataNameTeacher.Rows[0];
                    nameTeacher = table["completo"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                nameTeacher = "Unknown User";
            }
            return nameTeacher;
        }
        public void DeleteTopic(int idTopic)
        {
            int result = 0;
            // Agrego parámetros
            prm.Clear();
            prm.Add("@idTopic", idTopic.ToString());

            //DialogResult dialogResult = MessageBox.Show("¿Deseá eliminar el anuncio?", "Confirmación de eliminación", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    // Query
            //    string sqlDeleteTopic = "DELETE FROM Topic WHERE IdTopic = @idTopic";
            //    result = accion.AccionEjecutar(sqlDeleteTopic, prm);

            //    if (result > 0)
            //    {
            //        MessageBox.Show("Anuncio eliminado");
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se pudo eliminar el anuncio");
            //    }
            //}
        }
        public string GetNameCourse(int idCourse)
        {
            string course = "";
            // Agrego parámetros
            prm.Clear();
            prm.Add("@idCourse", idCourse.ToString());

            try
            {
                // Query
                string sqlSelectCourse = "SELECT Instrument FROM Course WHERE IdCourse = @idCourse";
                var dataCourse = select.SelectData(sqlSelectCourse, prm);
                if (dataCourse.Rows.Count > 0)
                {
                    var table = dataCourse.Rows[0];
                    course = table["Instrument"].ToString(); 
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                course = "Unknown course";
            }

            return course;
        }
        public Cursada GetCursada(int idCursada)
        {
            Cursada cursada = new Cursada();

            // Agregamos parámetros
            prm.Clear();
            prm.Add("@idCursada", idCursada.ToString());

            try
            {
                // Query
                string sqlSelectCursada = "SELECT IdCourse, IdTeacher, StarTime, EndTime FROM Cursada WHERE IdCursada = @idCursada";
                var dataCursada = select.SelectData(sqlSelectCursada, prm);

                if (dataCursada.Rows.Count > 0)
                {
                    var table = dataCursada.Rows[0];
                    cursada = new()
                    {
                        IdCourse = int.Parse(table["IdCourse"].ToString()),
                        IdTeacher = int.Parse(table["IdTeacher"].ToString()),
                        StarTime = Convert.ToDateTime(table["StarTime"].ToString()),
                        EndTime = Convert.ToDateTime(table["EndTime"].ToString()),
                    };
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                cursada = null;
            }
            return cursada;
        }
    }
}
