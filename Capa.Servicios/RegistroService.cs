using Capa.Base.De.Datos;
using SchoolMusic.BD;
using SchoolMusic.Entidades;
using System.Data;

namespace SchoolMusic.Serv
{
    public class RegistroService
    {
        // Crreamos instancias a objetos y clase que vamos a necesitar
        private Users userFound = null;
        private Student student = null;
        private Teacher teacher = null;
        private Course course = null;
        private Cursada cursada = null;
        private CnxAccion accion = new CnxAccion();
        private CnxSelect select = new CnxSelect();
        // Creamos un diccionario para pasar los parámetros.
        Dictionary<string, string> prm = new Dictionary<string, string>();

        public bool AddUser(Users user)
        {
            // Agrego nuevo Usuario a la tabla Users
            int result = 0;
            // Agrego parametros 
            prm.Add("@Username", user.Username);
            prm.Add("@UserPassword", user.UserPassword);
            // Query
            string sqlInsertUsers = "INSERT INTO Users (Username,UserPassword) " +
                    "VALUES (@Username,@UserPassword)";

            result = accion.AccionEjecutar(sqlInsertUsers, prm);
            if (result > 0 && result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int AddStudent(Student student)
        {
            // Agrego nuevo Alumno a la tabla Student
            int result = 0;
            // Agrego parametros
            prm.Add("@nameStudent", student.NameStudent);
            prm.Add("@surname", student.Surname);
            prm.Add("@mail", student.Mail);
            prm.Add("@dni", student.Dni.ToString());
            prm.Add("@age", student.Age.ToString());
            prm.Add("@idUser", student.IdUser.ToString());
            prm.Add("@genero", student.Genero.ToString());

            // Query
            string sqlInsertStudent = "INSERT INTO Student (NameStudent,Surname,Mail,Dni,Age,IdUser,Genero) " +
                  "VALUES (@nameStudent,@surname,@mail,@dni,@age,@idUser,@genero)";

            result = accion.AccionEjecutar(sqlInsertStudent, prm);

            return result;
        }
        public int AddTeacher(Teacher teacher)
        {
            // Agrego nuevo profesor a la tabla Teacher
            int result = 0;
            // Agrego parametros
            prm.Add("@nameTeacher", teacher.NameTeacher);
            prm.Add("@surname", teacher.Surname);
            prm.Add("@mail", teacher.Mail);
            prm.Add("@dni", teacher.Dni.ToString());
            prm.Add("@age", teacher.Age.ToString());
            prm.Add("@idUser", teacher.IdUser.ToString());
            prm.Add("@genero", teacher.Genero);
            // Query
            string sqlInsertTeacher = "INSERT INTO Teacher (NameTeacher,Surname,Mail,Dni,Age,IdUser,Genero) " +
                  "VALUES (@nameTeacher,@surname,@mail,@dni,@age,@idUser,@genero)";

            result = accion.AccionEjecutar(sqlInsertTeacher, prm);

            return result;
        }
        public int GetIdUser(Users users)
        {
            // Traemos el Id del Usuario
            int result = 0;
            // Agrego parametros
            prm.Clear();
            prm.Add("@username", users.Username);
            prm.Add("@userPassword", users.UserPassword);

            // Query
            string sqlSelectUser = "SELECT * FROM Users WHERE Username = @username AND UserPassword = @userPassword";

            var table = select.SelectData(sqlSelectUser, prm).Rows[0];
            userFound = new Users()
            {
                IdUser = int.Parse(table["IdUser"].ToString()),
                Username = table["Username"].ToString(),
                UserPassword = table["UserPassword"].ToString()
            };
            //result = int.Parse(table["IdUser"].ToString());
            return result = userFound.IdUser;
        }
    }
}
