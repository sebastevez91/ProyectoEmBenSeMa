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
        public bool RecoverPassword(string mail, string tipo)
        {
            string newPassword = new Random().Next().ToString();
            int result = 0;

            // Verificar tipo válido
            if (tipo != "Alumno" && tipo != "Profesor")
            {
                Console.WriteLine("Error: Tipo no válido. Debe ser 'Alumno' o 'Profesor'.");
                return false;
            }

            try
            {
                // Definir consulta según tipo
                string sqlQueryChange = tipo == "Alumno"
                    ? "SELECT IdUser FROM Student WHERE Mail = @mail"
                    : "SELECT IdUser FROM Teacher WHERE Mail = @mail";

                // Agregar parámetros y ejecutar consulta
                prm.Clear();
                prm.Add("@mail", mail);
                var dataUser = select.SelectData(sqlQueryChange, prm);

                if (dataUser != null && dataUser.Rows.Count > 0)
                {
                    var table = dataUser.Rows[0];
                    int idUser = int.Parse(table["IdUser"].ToString());

                    // Actualizar contraseña
                    prm.Clear();
                    prm.Add("@userPassword", newPassword);
                    prm.Add("@idUser", idUser.ToString());
                    string sqlUpdatePass = "UPDATE Users SET UserPassword = @userPassword, ChangePassword = 1 WHERE IdUser = @idUser";

                    result = accion.AccionEjecutar(sqlUpdatePass, prm);

                    if (result > 0)
                    {
                        EnviarMail(mail, newPassword);
                    }
                }
                else
                {
                    Console.WriteLine($"No se encontró ningún usuario con el correo {mail} en la tabla {tipo}.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return result > 0;
        }
        public void EnviarMail(string mail, string newPassword)
        {
            mailData.mailTo = mail;
            mailData.subject = "Recuperación de contraseña";
            mailData.body = $"Ingresa con tu nombre de usuario y la siguiente clave: {newPassword}";
            mailService.sendMail(mailData);
        }
    }
}
