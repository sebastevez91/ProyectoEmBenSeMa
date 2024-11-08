using SchoolMusic.Entidades;
using System.Text.RegularExpressions;

namespace Capa.Servicios
{
    public class ValidacionGeneral
    {
        public static bool mailValido(string email)
        {
            // Patrón de expresión regular para validar direcciones de correo electrónico
            string patronEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Verifica si el email coincide con el patrón
            return Regex.IsMatch(email, patronEmail);
        }
        private static bool nombreValido(string nombre)
        {
            // Permitimos letras mayúsculas y minúsculas, espacios y apóstrofos.
            Regex regex = new Regex(@"^[a-zA-Z\s'-]+$");


            return regex.IsMatch(nombre);
        }
        public static bool telefonoValido(string tel)
        {
            //valida números de teléfono en Argentina
            Regex regex = new Regex(@"^(0\d{2}-)?\d{7,}$");


            return regex.IsMatch(tel);
        }
        public static bool dniValido(string dni)
        {
            // Expresión regular para validar el formato del DNI argentino
            Regex regex = new Regex(@"^\d{7,8}$");

            // Comprobamos si el DNI coincide con el patrón
            if (!regex.IsMatch(dni))
                return false;

            // Verificamos que la longitud sea correcta
            if (dni.Length != 7 && dni.Length != 8)
                return false;

            // Verificamos que todos los caracteres sean dígitos
            foreach (char c in dni)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }
        private static bool validarContraseña(string contra1, string contra2)
        {
            if (contra1 == contra2 && contra1.Length > 7)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool validaRegistro(
            string name,
            string surname,
            string dni,
            string age,
            string mail,
            string username,
            string password,
            string rePassword)
        {
            int parseAge;
            bool valido = true;
            if (name == null || surname == null || dni == null || age == null || mail == null || username == null || password == null || rePassword == null)
            {
                valido = false;
            }
            // Nombre 
            if (name == "")
            {
                valido = false;
            }
            if (surname == "")
            {
                valido = false;
            }
            // Nombre usuario
            if (nombreValido(username) == false)
            {
                valido = false;
            }
            // Dni
            if (dniValido(dni.ToString()) == false)
            {               
                valido = false;
            }
            // Edad
            if (int.TryParse(age, out parseAge))
            {
                if (parseAge <= 0 || parseAge > 110)
                {
                    valido = false;
                } 
            }
            // Email
            if (mailValido(mail) == false)
            {
                valido = false;
            }
            // Contraseña
            if (validarContraseña(password, rePassword) == false)
            {
                valido = false;
            }
            return valido;
        }
        public static bool ActualizaRegistro(
            string name,
            string surname,
            string dni,
            string age,
            string mail)
        {
            int parseAge;
            bool valido = true;
            if (name == null || surname == null || dni == null || age == null || mail == null)
            {
                return false;
            }
            // Nombre 
            if (name == "")
            {
                valido = false;
            }
            // Apellido
            if (surname == "")
            {
                valido = false;
            }
            // Dni
            if (dniValido(dni.ToString()) == false)
            {
                valido = false;
            }
            // Edad
            if (int.TryParse(age, out parseAge))
            {
                if (parseAge <= 0 || parseAge > 110)
                {
                    valido = false;
                }
            }
            // Email
            if (mailValido(mail) == false)
            {
                valido = false;
            }
            return valido;
        }
    }
}
