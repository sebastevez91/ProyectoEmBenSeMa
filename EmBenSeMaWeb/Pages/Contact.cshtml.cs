using Capa.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SchoolMusic.Web.Pages
{
    public class Index1Model : PageModel
    {
        private readonly SchoolMusic.Web.Service.MailService _mailService;

        public Index1Model( Service.MailService mailService)
        {
            _mailService = mailService;
        }
        public void OnGet()
        {
        }

        [BindProperty]
        public MailData Mail { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }


        public IActionResult OnPost(string name, string surname)
        {

            // Construimos el cuerpo del correo con la información proporcionada por el usuario.
            Mail.subject = "Consulta a School EmBenSeMa";
            Mail.body = $"Recibimos tu consulta en la brevedad te escribiremos." +
                $"Asunto: {Mail.subject}" +
                $"Nombre: {Name} {Surname}<br>Email: {Mail.mailTo}<br>Mensaje: {Mail.body}";
            try
            {
                _mailService.sendMail(Mail);
                TempData["Message"] = "¡Correo enviado exitosamente!";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Ocurrió un error al enviar el correo. Por favor, inténtelo más tarde.";
            }


            return RedirectToPage();
        }
    }
}
