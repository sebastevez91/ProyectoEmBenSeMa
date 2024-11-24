using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;

namespace SchoolMusic.Web.Pages.Notifications
{
    public class IndexNotificationModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;

        public IndexNotificationModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }

        public IList<Notification> ReceivedNotifications { get; set; } = default!;
        public IList<Notification> SentNotifications { get; set; } = default!;
        public string CurrentView { get; set; } = "Recibidos"; // Vista predeterminada
        public async Task<IActionResult> OnGetAsync()
        {
            var userId = User.FindFirst("UserId")?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToPage("/Logins/LoginUser");
            }

            // Todas las notificaciones no leídas en una sola operación
            await MarcarNotificacionesComoLeidasAsync(int.Parse(userId));

            // Cargar notificaciones recibidas y enviadas
            ReceivedNotifications = await _context.Notification
                .Where(n => n.NotificationTo == int.Parse(userId))
                .ToListAsync();
            
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var userId = User.FindFirst("UserId")?.Value;
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToPage("/Logins/LoginUser");
            }

            var action = Request.Form["action"]; // Obtener el valor del botón presionado

            if (action == "Recibidos")
            {
                CurrentView = "Recibidos";
                // Obtener notificaciones recibidas
                ReceivedNotifications = await _context.Notification
                    .Where(n => n.NotificationTo == int.Parse(userId))
                    .ToListAsync();
            }
            else if (action == "Enviados")
            {
                CurrentView = "Enviados";
                // Obtener notificaciones enviadas
                SentNotifications = await _context.Notification
                    .Where(n => n.NotificationFrom == int.Parse(userId))
                    .ToListAsync();
            }
            return Page();
        }

        // Método para actualizar el estado de las notificaciones a "leído"
        private async Task MarcarNotificacionesComoLeidasAsync(int userId)
        {
            // Seleccionar las notificaciones no leídas del usuario
            var notificacionesNoLeidas = _context.Notification
                .Where(n => n.NotificationTo == userId && !n.Status);

            // Actualizar el campo Status a true para todas las no leídas
            await notificacionesNoLeidas.ForEachAsync(notification =>
            {
                notification.Status = true;
            });

            // Guardar los cambios en una sola operación
            await _context.SaveChangesAsync();
        }
    }
}
