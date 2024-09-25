using Capa.Base.De.Datos;
using SchoolMusic.BD;
using SchoolMusic.Entidades;
using System.Data;

namespace SchoolMusic.Serv
{

    public class StudentsService
    {
        Dictionary<string, string> prm = new Dictionary<string, string>();
        private CnxAccion accion = new CnxAccion();
        private CnxSelect select = new CnxSelect();
        private Student student;

        public Student GetStudent(int idUser)
        {
            int result = 0;
            // Agrego parametros
            prm.Clear();
            prm.Add("@idUser", idUser.ToString());
            try
            {
                // Query
                string sqlQueryStudent = "SELECT * FROM Student WHERE IdUser = @idUser";

                var table = select.SelectData(sqlQueryStudent, prm).Rows[0];

                student = new()
                {
                    IdStudent = int.Parse(table["IdStudent"].ToString()),
                    NameStudent = table["NameStudent"].ToString(),
                    Surname = table["Surname"].ToString(),
                    Mail = table["Mail"].ToString(),
                    Dni = int.Parse(table["Dni"].ToString()),
                    Age = int.Parse(table["Age"].ToString()),
                    IdUser = int.Parse(table["IdUser"].ToString()),
                    Genero = table["Genero"].ToString()
                };
            }
            catch (NullReferenceException)
            {

                //MessageBox.Show("Error");
            }

            return student;
        }
        public List<Cursada> GetListCursada(int idStudent)
        {
            List<Inscription> listInscription = new List<Inscription>();
            List<Cursada> listCursada = new List<Cursada>();
            // Agrego parametros
            prm.Clear();
            prm.Add("@idStudent", idStudent.ToString());

            // Query
            string sqlQueryInscription = "SELECT * FROM Inscription WHERE IdStudent = @idStudent";
            var dataInscription = select.SelectData(sqlQueryInscription, prm);

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
                    listCursada.Add(GetCursada(i.idCursada));
                }
            }
            return listCursada;
        }
        public Course GetCourse(int idCourse)
        {
            Course course = null;

            // Agrego parametros
            prm.Clear();
            prm.Add("@idCourse", idCourse.ToString());

            // Query
            string sqlQueryCourse = "SELECT IdCourse, CONCAT('Curso de ', Instrument) AS NameCourse FROM Course WHERE IdCourse = @idCourse";
            var dataCourse = select.SelectData(sqlQueryCourse, prm).Rows[0];

            course = new Course()
            {
                IdCourse = int.Parse(dataCourse["IdCourse"].ToString()),
                Instrument = dataCourse["NameCourse"].ToString(),
            };

            return course;
        }
        private Cursada GetCursada(int idCursada)
        {
            Cursada cursada = new Cursada();
            // Agrego parametros
            prm.Clear();
            prm.Add("@idCursada", idCursada.ToString());

            // Query
            string sqlQueryCursada = "SELECT * FROM Cursada WHERE IdCursada = @idCursada";
            var table = select.SelectData(sqlQueryCursada, prm).Rows[0];

            cursada = new()
            {
                IdCursada = int.Parse(table["IdCursada"].ToString()),
                IdCourse = int.Parse(table["IdCourse"].ToString()),
                Initiation = Convert.ToDateTime(table["Initiation"].ToString()),
                Finish = Convert.ToDateTime(table["Finish"].ToString()),
                IdTeacher = int.Parse(table["IdTeacher"].ToString()),
                StarTime = Convert.ToDateTime(table["StartTime"].ToString()),
                EndTime = Convert.ToDateTime(table["EndTime"].ToString()),
                Vacantes = int.Parse(table["Vacantes"].ToString()),
                Days = table["Days"].ToString()
            };
            return cursada;
        }
        public Teacher GetTeacher(int idTeacher)
        {
            Teacher teacher = new Teacher();
            // Agrego parametros
            prm.Clear();
            prm.Add("@idTeacher", idTeacher.ToString());

            // Query
            string sqlQueryTeacher = "SELECT * FROM Teacher WHERE IdTeacher = @idTeacher";
            var table = select.SelectData(sqlQueryTeacher, prm).Rows[0];

            teacher = new()
            {
                IdTeacher = int.Parse(table["IdTeacher"].ToString()),
                NameTeacher = table["NameTeacher"].ToString(),
                Surname = table["Surname"].ToString(),
                Mail = table["Mail"].ToString(),
                Dni = int.Parse(table["Dni"].ToString()),
                Age = int.Parse(table["Age"].ToString()),
                IdUser = int.Parse(table["IdUser"].ToString()),
                Genero = table["Genero"].ToString()
            };
            return teacher;
        }
        public void DeleteInscription(int idCursada, int idStudent)
        {
            int result = 0;
            //DialogResult dialogResult = MessageBox.Show("¿Queres cancelar la cursada?", "Cancelación de cursada", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (dialogResult == DialogResult.Yes)
            //{
            //    // Agrego parámetros
            //    prm.Clear();
            //    prm.Add("@idCursada", idCursada.ToString());
            //    prm.Add("@idStudent", idStudent.ToString());

            //    // Query
            //    string sqlDeleteinscription = "DELETE FROM Inscription WHERE IdCursada = @idCursada AND IdStudent = @idStudent";
            //    result = accion.AccionEjecutar(sqlDeleteinscription, prm);
            //    if (result > 0)
            //    {
            //        MessageBox.Show("Inscripción a cursada cancelada");
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se pudo cancelar la cursada");
            //    }
            //}
        }
    }
}
