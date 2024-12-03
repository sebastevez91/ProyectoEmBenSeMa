using Capa.Base.De.Datos;
using SchoolMusic.BD;
using SchoolMusic.Entidades;
using System.Data;

namespace SchoolMusic.Serv
{
    public class CursadaService
    {
        Dictionary<string, string> prm = new Dictionary<string, string>();
        private CnxSelect select = new CnxSelect();
        private CnxAccion accion = new CnxAccion();

        public Cursada GetCursada(int id)
        {
            Cursada cursada = new Cursada();
            // Agrego parametros
            prm.Clear();
            prm.Add("@idCursada", id.ToString());

            try
            {
                // Query
                string sqlQueryCursada = "SELECT * FROM Cursada WHERE IdCursada = @idCursada";
                var dataCursada = select.SelectData(sqlQueryCursada, prm);
                if (dataCursada.Rows.Count > 0)
                {
                    var table = dataCursada.Rows[0];
                    cursada = new()
                    {
                        IdCursada = int.Parse(table["IdCursada"].ToString()),
                        IdCourse = int.Parse(table["IdCourse"].ToString()),
                        Initiation = Convert.ToDateTime(table["Initiation"].ToString()),
                        Finish = Convert.ToDateTime(table["Finish"].ToString()),
                        IdTeacher = int.Parse(table["IdTeacher"].ToString()),
                        StarTime = Convert.ToDateTime(table["StarTime"].ToString()),
                        EndTime = Convert.ToDateTime(table["EndTime"].ToString()),
                        Vacantes = int.Parse(table["Vacantes"].ToString()),
                        Description = table["Description"].ToString(),
                        Days = table["Days"].ToString()
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
        public Course GetCourse(int id)
        {
            Course course = new Course();
            // Agrego parametros
            prm.Clear();
            prm.Add("@idCourse", id.ToString());

            // Query
            string sqlQueryCourse = "SELECT *, CONCAT('Curso de ', Instrument) AS Completo FROM Course WHERE IdCourse = @idCourse";
            try
            {
                var dataCourse = select.SelectData(sqlQueryCourse, prm);

                if (dataCourse.Rows.Count > 0)
                {
                    var table = dataCourse.Rows[0];
                    course = new Course()
                    {
                        IdCourse = int.Parse(table["IdCourse"].ToString()),
                        Instrument = table["Completo"].ToString(),
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                course = null;
            }
            return course;
        }
        public List<Student> GetStudentList(int id)
        {
            List<Inscription> listInscription = new List<Inscription>();
            List<Student> listStudents = new List<Student>();
            // Agrego parametros
            prm.Clear();
            prm.Add("@idCursada", id.ToString());

            // Query
            string sqlSelectInscription = "SELECT * FROM Inscription WHERE IdCursada = @idCursada";
            var dataInscription = select.SelectData(sqlSelectInscription, prm);

            if (dataInscription != null && dataInscription.Rows.Count > 0)
            {
                foreach (DataRow ins in dataInscription.Rows)
                {
                    listInscription.Add(new Inscription()
                    {
                        idInscription = int.Parse(ins["IdInscription"].ToString()),
                        idStudent = int.Parse(ins["IdStudent"].ToString()),
                        idCursada = int.Parse(ins["IdCursada"].ToString()),
                        dateInscription = Convert.ToDateTime(ins["DateInscription"].ToString()),
                    });
                }
                foreach (Inscription i in listInscription)
                {
                    listStudents.Add(GetStudent(i.idStudent));
                }
            }
            return listStudents;
        }
        private Student GetStudent(int id)
        {
            Student student = null;
            // Agrego parametros
            prm.Clear();
            prm.Add("@idStudent", id.ToString());

            try
            {
                // Query
                string sqlQueryStudent = "SELECT IdStudent, NameStudent, Surname, Mail FROM Student WHERE IdStudent = @idStudent";
                var dataStudent = select.SelectData(sqlQueryStudent, prm);

                if (dataStudent.Rows.Count > 0)
                {
                    var table = dataStudent.Rows[0];
                    student = new()
                    {
                        IdStudent = int.Parse(table["IdStudent"].ToString()),
                        NameStudent = table["NameStudent"].ToString(),
                        Surname = table["Surname"].ToString(),
                        Mail = table["Mail"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }
            return student;
        }
        public int GetCantidad(int id)
        {
            int result = 0;
            // Agrego parametros
            prm.Clear();
            prm.Add("@idCursada", id.ToString());

            // Query
            string sqlQueryInscription = "SELECT IdInscription FROM Inscription WHERE IdCursada = @idCursada";
            try
            {
                var dataCantidad = select.SelectData(sqlQueryInscription, prm);
                result = dataCantidad.Rows.Count;
            }
            catch (Exception e)
            {

                result = 0;
            }
            return result;
        }
    }
}
