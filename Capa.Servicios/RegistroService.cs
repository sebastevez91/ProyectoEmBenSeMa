using Capa.Base.De.Datos;
using SchoolMusic.BD;
using SchoolMusic.Entidades;

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

        public int AddUser(Users user)
        {
            try
            {
                // Configuración de parámetros
                var parametros = new Dictionary<string, object>
                                {
                                    { "@Username", user.Username },
                                    { "@UserPassword", user.UserPassword },
                                    { "@Rol", user.Rol }
                                };

                // Consulta SQL para insertar y devolver el ID generado
                string sqlInsertUsers = @"INSERT INTO Users (Username, UserPassword, Rol) 
                                        VALUES (@Username, @UserPassword, @Rol);
                                        SELECT CAST(SCOPE_IDENTITY() AS INT);";

                // Ejecutar la acción y obtener el resultado
                int userId = accion.AccionEjecutarEscalar(sqlInsertUsers, parametros);

                // Retornar el ID generado
                return userId;
            }
            catch (Exception ex)
            {
                // Manejo de errores
                throw new Exception("Error al agregar el usuario a la base de datos", ex);
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
    }
}
