using Capa.Base.De.Datos;
using SchoolMusic.BD;
using SchoolMusic.Entidades;
using System.Data;

namespace SchoolMusic.Serv
{
    public class TeacherService
    {
        Dictionary<string, string> prm = new Dictionary<string, string>();
        private CnxSelect select = new CnxSelect();
        private CnxAccion accion = new CnxAccion();
        private Teacher teacher = null;
        public bool AddCursada(Cursada cursada)
        {
            // Agrego nueva cursada a la tabla Cursada
            int result = 0;

            // Agrego parametros
            prm.Clear();
            prm.Add("@idCourse", cursada.IdCourse.ToString());
            prm.Add("@initiation", cursada.Initiation.ToString());
            prm.Add("@finish", cursada.Finish.ToString());
            prm.Add("@idTeacher", cursada.IdTeacher.ToString());
            prm.Add("@starTime", cursada.StarTime.ToString());
            prm.Add("@endTime", cursada.EndTime.ToString());
            prm.Add("@vacantes", cursada.Vacantes.ToString());
            prm.Add("@days", cursada.Days.ToString());
            prm.Add("@description", cursada.Description);
            prm.Add("@payFee", cursada.PayFee.ToString());


            // Query
            string sqlInsertCourse = "INSERT INTO Cursada (IdCourse,Initiation,Finish,IdTeacher,StarTime,EndTime,Vacantes,Days,Description,PayFee) " +
                "VALUES (@idCourse,TRY_CONVERT(DATETIME, @initiation, 103),TRY_CONVERT(DATETIME, @finish, 103),@idTeacher,CONVERT(DATETIME, @starTime, 103),CONVERT(DATETIME, @endTime, 103),@vacantes,@days,@description,@payFee)";

            result = accion.AccionEjecutar(sqlInsertCourse, prm);
            
            return result > 0 ? true : false;
        }
        public bool AddTablon(string idCursada)
        {
            int result = 0;
            // Agrego parámetros
            prm.Clear();
            prm.Add("@idCursada", idCursada);

            // Query
            string sqlInsertTablon = "INSERT INTO Tablon (IdCursada) VALUES (@idCursada)";
            result = accion.AccionEjecutar(sqlInsertTablon, prm);

            return result > 0? true : false;
        }
        public Teacher GetTeacher(int idUser)
        {
            // Agrego parametros
            prm.Clear();
            prm.Add("@idUser", idUser.ToString());

            try
            {
                // Query
                string sqlSelectTeacher = "SELECT * FROM Teacher WHERE IdUser = @idUser";
                var dataTeacher = select.SelectData(sqlSelectTeacher, prm);

                if (dataTeacher.Rows.Count > 0)
                {
                    var table = dataTeacher.Rows[0];
                    teacher = new()
                    {
                        IdTeacher = int.Parse(table["IdTeacher"].ToString()),
                        NameTeacher = table["NameTeacher"].ToString(),
                        Surname = table["Surname"].ToString(),
                        Mail = table["Mail"].ToString(),
                        Dni = int.Parse(table["Dni"].ToString()),
                        Age = int.Parse(table["Age"].ToString()),
                        IdUser = int.Parse(table["IdUser"].ToString()),
                    }; 
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }

            return teacher;
        }
        public List<Cursada> GetCursadaList(int idTeacher)
        {
            List<Cursada> listCursada = new List<Cursada>();

            // Agrego parámetros
            prm.Clear();
            prm.Add("@idTeacher", idTeacher.ToString());

            // Query
            string sqlQueryCursada = "SELECT * FROM Cursada WHERE IdTeacher = @idTeacher";
            try
            {
                var dataCursada = select.SelectData(sqlQueryCursada, prm);

                if (dataCursada != null && dataCursada.Rows.Count > 0)
                {
                    foreach (DataRow c in dataCursada.Rows)
                    {
                        listCursada.Add(new Cursada()
                        {
                            IdCursada = int.Parse(c["IdCursada"].ToString()),
                            IdCourse = int.Parse(c["IdCourse"].ToString()),
                            Initiation = Convert.ToDateTime(c["Initiation"].ToString()),
                            Finish = Convert.ToDateTime(c["Finish"].ToString()),
                            IdTeacher = int.Parse(c["IdTeacher"].ToString()),
                            StarTime = Convert.ToDateTime(c["StarTime"].ToString()),
                            EndTime = Convert.ToDateTime(c["EndTime"].ToString()),
                            Vacantes = int.Parse(c["Vacantes"].ToString()),
                            Days = c["Days"].ToString(),
                            Description = c["Description"].ToString(),
                            PayFee = float.Parse(c["PayFee"].ToString())
                        });
                    }
                }
            }
            catch (Exception e)
            {

                listCursada = null;
            }
            return listCursada;
        }
        public List<Student> GetStudentList(int idCursada)
        {
            List<Inscription> listInscription = new List<Inscription>();
            List<Student> listStudents = new List<Student>();
            // Agrego parametros
            prm.Clear();
            prm.Add("@idCursada", idCursada.ToString());

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
        public List<Course> GetListCourse()
        {
            // Le pedimos a la base de datos todos los registros que hay en la tabla Course

            // Declaramos una lista
            List<Course> listCourse = new List<Course>();
            //Query
            string sqlQueryCurse = "SELECT * FROM Course";
            var dataCourse = select.SelectData(sqlQueryCurse, null);

            if (dataCourse != null && dataCourse.Rows.Count > 0)
            {
                foreach (DataRow c in dataCourse.Rows)
                {
                    listCourse.Add(new Course()
                    {
                        IdCourse = int.Parse(c["IdCourse"].ToString()),
                        Instrument = c["Instrument"].ToString()
                    });
                }
            }
            return listCourse;
        }
        private Student GetStudent(int idStudent)
        {
            Student student = null;
            // Agrego parametros
            prm.Clear();
            prm.Add("@idStudent", idStudent.ToString());

            try
            {
                // Query
                string sqlQueryStudent = "SELECT IdStudent, NameStudent, Surname FROM Student WHERE IdStudent = @idStudent";
                var dataStudent = select.SelectData(sqlQueryStudent, prm);

                if (dataStudent.Rows.Count > 0)
                {
                    var table = dataStudent.Rows[0];
                    student = new()
                    {
                        IdStudent = int.Parse(table["IdStudent"].ToString()),
                        NameStudent = table["NameStudent"].ToString(),
                        Surname = table["Surname"].ToString()
                    }; 
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }
            return student;
        }
        public Course GetCourse(int idCourse)
        {
            Course course = new Course();
            // Agrego parametros
            prm.Clear();
            prm.Add("@idCourse", idCourse.ToString());

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
        public bool ValidaCursada(Cursada cursada)
        {
            if (cursada.IdCourse != null && cursada.IdTeacher != null && cursada.Vacantes != null)
            {
                return true;
            }else if(cursada.StarTime == cursada.EndTime || cursada.EndTime < cursada.StarTime)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
