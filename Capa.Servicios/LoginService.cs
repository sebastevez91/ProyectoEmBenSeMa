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
        public Users LoginValido(string username, string password)
        {
            // Agrego parametros
            prm.Add("@username", username);
            prm.Add("@userPassword", password);

            // Query
            string sqlQueryLogin = "SELECT * FROM Users WHERE Username = @username AND UserPassword = @userPassword";
            try
            {
                var dataLogin = select.SelectData(sqlQueryLogin, prm);
                if (dataLogin != null && dataLogin.Rows.Count > 0)
                {
                    var table = dataLogin.Rows[0];

                    userFound = new Users
                    {
                        IdUser = int.Parse(table["IdUser"].ToString()),
                        Username = table["Username"].ToString(),
                        UserPassword = table["UserPassword"].ToString(),
                        Rol = table["Rol"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return userFound;
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
            int idUser = 0;
            // Agrego parametros
            prm.Clear();
            prm.Add("@dni", dni);
            prm.Add("@mail", mail);

            try
            {
                // Query
                string sqlQueryChange = "SELECT IdUser FROM Student WHERE Dni = @dni AND Mail = @mail";

                var dataStudent = select.SelectData(sqlQueryChange, prm);
                if (dataStudent != null && dataStudent.Rows.Count > 0)
                {
                    var table = dataStudent.Rows[0];

                    idUser = int.Parse(table["IdUser"].ToString());
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
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }
            return result > 0 ? true : false;
        }
        public bool RecoverPasswordTeacher(string dni, string mail)
        {
            string newPassword = new Random().Next().ToString();
            int result = 0;
            int idUser = 0;
            // Agrego parametros
            prm.Clear();
            prm.Add("@dni", dni);
            prm.Add("@mail", mail);

            try
            {
                // Query
                string sqlQueryChange = $"SELECT IdUser FROM Teacher WHERE Dni = @dni AND Mail = @mail";

                var dataTeacher = select.SelectData(sqlQueryChange, prm);
                if (dataTeacher != null && dataTeacher.Rows.Count > 0)
                {
                    var table = dataTeacher.Rows[0];

                    idUser = int.Parse(table["IdUser"].ToString());

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
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
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
