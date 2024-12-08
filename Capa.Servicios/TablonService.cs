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
        public List<Topic> GetListTopic(int id)
        {
            // Agrego los parámetros
            listTopic.Clear();
            prm.Clear();
            prm.Add("@idCursada", id.ToString());

            // Query
            string sqlSelectTopic = "SELECT * FROM Topic WHERE IdCursada = @idCursada";
            var dataTopic = select.SelectData(sqlSelectTopic, prm);

            if (dataTopic != null && dataTopic.Rows.Count > 0)
            {
                foreach (DataRow top in dataTopic.Rows)
                {
                    listTopic.Add(new Topic()
                    {
                        IdTopic = int.Parse(top["IdTopic"].ToString()),
                        Title = top["Title"].ToString(),
                        Content = top["Content"].ToString(),
                        DateTopic = Convert.ToDateTime(top["DateTopic"].ToString())
                    });
                }
            }
            return listTopic;
        }
        public bool SetTopic(Topic topic)
        {
            // Agrego parámetros
            prm.Clear();
            prm.Add("@title", topic.Title);
            prm.Add("@content", topic.Content);
            prm.Add("@idCursada", topic.IdCursada.ToString());

            // Query
            string sqlInsertTopic = "INSERT INTO Topic (Title,DateTopic,IdCursada,Content)" +
                "VALUES (@title,GETDATE(),@idCursada,@content)";
            var result = accion.AccionEjecutar(sqlInsertTopic, prm);
            
            return result < 0 ? true: false;
        }
        public List<Coment> GetListComent(string id)
        {
            List<Coment> listComent = new List<Coment>();

            // Agrego parámetros 
            prm.Clear();
            prm.Add("@idTopic", id);

            // Query
            string sqlSelectComent = "SELECT * FROM Comentario WHERE IdTopic = @idTopic";
            var dataComent = select.SelectData(sqlSelectComent, prm);

            if (dataComent != null && dataComent.Rows.Count > 0)
            {
                foreach (DataRow row in dataComent.Rows)
                {
                    listComent.Add(new Coment()
                    {
                        IdComent = int.Parse(row["IdComent"].ToString()),
                        IdTopic = int.Parse(row["IdTopic"].ToString()),
                        Content = row["Content"].ToString(),
                        DateComent = Convert.ToDateTime(row["DateComent"].ToString()),
                        Author = row["Author"].ToString()
                    });
                }
            }
            return listComent;
        }
        public bool SetComent(Coment coment)
        {
            int result = 0;
            // Agrego parámetros
            prm.Clear();
            prm.Add("@content", coment.Content);
            prm.Add("@author", coment.Author);
            prm.Add("@idTopic", coment.IdTopic.ToString());

            // Query
            string sqlInsertComent = "INSERT INTO Comentario (Content,DateComent,Author,IdTopic)" +
                "VALUES (@content,GETDATE(),@author,@idTopic)";

            result = accion.AccionEjecutar(sqlInsertComent, prm);


            return result < 0 ? true: false;
        }
        public string GetNameUser(Users users)
        {
            string nameUser = "";

            // Agrego parámetros
            prm.Clear();
            prm.Add("@idUser", users.IdUser.ToString());

            // Query
            string sqlSelect = users.Rol == "Alumno"
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
        public string GetNameTeacher(int id)
        {
            string nameTeacher = "";

            // Agrego parámetros
            prm.Clear();
            prm.Add("@idTeacher", id.ToString());

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
