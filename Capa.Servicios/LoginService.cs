using Capa.Base.De.Datos;
using Capa.Entidades;
using Capa.Servicios;
using SchoolMusic.BD;
using SchoolMusic.Entidades;

namespace SchoolMusic.Serv
{
    public class LoginService
    {
        Dictionary<string, string> prm = new Dictionary<string, string>();
        CnxSelect select = new CnxSelect();
        CnxAccion accion = new CnxAccion();
        MailData mailData = new MailData();
        MailService mailService = new MailService();
        Users userFound = null;
        Student student = null;
        Teacher teacher = null;
        public bool LoginValido(string username, string password)
        {
            int result = 0;
            // Agrego parametros
            prm.Add("@username", username);
            prm.Add("@userPassword", password);

            // Query
            string sqlQueryLogin = "SELECT * FROM Users WHERE Username = @username AND UserPassword = @userPassword";
            try
            {
                var table = select.SelectData(sqlQueryLogin, prm).Rows[0];
                if (table != null)
                {
                    userFound = new()
                    {
                        IdUser = int.Parse(table["IdUser"].ToString()),
                        Username = table["Username"].ToString(),
                        UserPassword = table["UserPassword"].ToString()
                    };
                    result = 1;
                }
            }
            catch (Exception e)
            {

                result = 0;
            }

            return result > 0 ? true : false;
        }
        public Users UserSession()
        {
            Users userSession = userFound;
            return userSession;
        }
        public bool RecoverPasswordStudent(string dni, string mail)
        {
            string newPassword = new Random().Next().ToString();
            int result = 0;
            // Agrego parametros
            prm.Clear();
            prm.Add("@dni", dni);
            prm.Add("@mail", mail);

            // Query
            string sqlQueryChange = "SELECT * FROM Student WHERE Dni = @dni AND Mail = @mail";

            var table = select.SelectData(sqlQueryChange, prm).Rows[0];
            if (table != null)
            {
                student = new()
                {
                    IdStudent = int.Parse(table["IdStudent"].ToString()),
                    NameStudent = table["NameStudent"].ToString(),
                    Surname = table["Surname"].ToString(),
                    Mail = table["Mail"].ToString(),
                    Dni = int.Parse(table["Dni"].ToString()),
                    Age = int.Parse(table["Age"].ToString()),
                    IdUser = int.Parse(table["IdUser"].ToString())
                };
                // Agrego parametros
                prm.Clear();
                prm.Add("@userPassword", newPassword);
                prm.Add("@idUser", student.IdUser.ToString());
                string sqlUpdatePass = "UPDATE Users SET UserPassword = @userPassword, ChangePassword = 1 WHERE IdUser = @idUser";
                result = accion.AccionEjecutar(sqlUpdatePass, prm);
                if (result > 0)
                {
                    EnviarMail(mail, newPassword);
                }
            }
            return result > 0 ? true : false;
        }
        public bool RecoverPasswordTeacher(string dni, string mail)
        {
            string newPassword = new Random().Next().ToString();
            int result = 0;
            // Agrego parametros
            prm.Clear();
            prm.Add("@dni", dni);
            prm.Add("@mail", mail);

            // Query
            string sqlQueryChange = $"SELECT * FROM Teacher WHERE Dni = @dni AND Mail = @mail";

            var table = select.SelectData(sqlQueryChange, prm).Rows[0];
            if (table != null)
            {
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
                // Agrego parametros
                prm.Clear();
                prm.Add("@userPassword", newPassword);
                prm.Add("@idUser", student.IdUser.ToString());
                string sqlUpdatePass = "UPDATE Users SET UserPassword = @userPassword, ChangePassword = 1 WHERE IdUser = @idUser";
                result = accion.AccionEjecutar(sqlUpdatePass, prm);
                if (result > 0)
                {
                    EnviarMail(mail, newPassword);
                }
            }
            return result > 0 ? true : false;
        }
        public void EnviarMail(string mail, string newPassword)
        {
            mailData.mailTo = mail;
            mailData.subject = "Recuperación de contraseña";
            mailData.body = $"Ingresa con tu nombre de usuario y la siguiente clave: {newPassword}";
            mailService.sendMail(mailData);
        }
        public string TipoUser(string tipo)
        {
            if (tipo == "Alumnos")
            {
                return "Student";
            }
            else
            {
                return "Teacher";
            }
        }
    }
}
