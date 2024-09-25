using Capa.Base.De.Datos;
using SchoolMusic.Entidades;

namespace SchoolMusic.Serv
{
    public class UpdateService
    {
        Dictionary<string, string> prm = new Dictionary<string, string>();
        CnxAccion accion = new CnxAccion();

        public bool UpdateUsers(Users updateUser)
        {
            int result = 0;
            // Agrego parametros
            prm.Clear();
            prm.Add("@username", updateUser.Username);
            prm.Add("@userPassword", updateUser.UserPassword);
            prm.Add("@idUser", updateUser.IdUser.ToString());

            // Query
            string sqlUpdateUser = "UPDATE Users SET Username = @username, UserPassword = @userPassword, ChangePassword = 1 WHERE IdUser = @idUser";
            result = accion.AccionEjecutar(sqlUpdateUser, prm);

            return result > 0 ? true : false;
        }
        public void UpdateStudent(Student updateStudent)
        {
            int result = 0;
            // Agrego parametros
            prm.Clear();
            prm.Add("@idStudent", updateStudent.IdStudent.ToString());
            prm.Add("@nameStudent", updateStudent.NameStudent);
            prm.Add("@surname", updateStudent.Surname);
            prm.Add("@mail", updateStudent.Mail);
            prm.Add("@dni", updateStudent.Dni.ToString());
            prm.Add("@Age", updateStudent.Age.ToString());

            // Query
            string sqlQueryUpdate = "UPDATE Student SET NameStudent = @nameStudent, Surname = @surname, Mail = @mail, Dni = @dni, Age = @age WHERE IdStudent = @idStudent";
            result = accion.AccionEjecutar(sqlQueryUpdate, prm);
            if(result < 0)
            {
                //MessageBox.Show("No se pudo modificar los datos personales");
            }
        }
        public void UpdateTeacher(Teacher updateTeacher)
        {
            int result = 0;
            // Agrego parametros
            prm.Clear();
            prm.Add("@idTeacher", updateTeacher.IdTeacher.ToString());
            prm.Add("@nameTeacher", updateTeacher.NameTeacher);
            prm.Add("@surname", updateTeacher.Surname);
            prm.Add("@mail", updateTeacher.Mail);
            prm.Add("@dni", updateTeacher.Dni.ToString());
            prm.Add("@Age", updateTeacher.Age.ToString());

            // Query
            string sqlQueryUpdate = "UPDATE Teacher SET NameTeacher = @nameTeacher, Surname = @surname, Mail = @mail, Dni = @dni, Age = @age WHERE IdTeacher = @idTeacher";
            result = accion.AccionEjecutar(sqlQueryUpdate, prm);
            if (result < 0)
            {
                //MessageBox.Show("No se pudo modificar los datos personales");
            }
        }
    }
}
