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

        public async Task<IActionResult> OnPostMarkAsReadAsync(int id)
        {
            var notification = await _context.Notification.FindAsync(id);

            if (notification == null)
            {
                return NotFound();
            }

            // Actualizar el estado de la notificación a true
            notification.Status = true;
            await _context.SaveChangesAsync();

            // Recargar las notificaciones
            var userId = User.FindFirst("UserId")?.Value;

            if (CurrentView == "Recibidos")
            {
                ReceivedNotifications = await _context.Notification
                    .Where(n => n.NotificationTo == int.Parse(userId))
                    .ToListAsync();
            }
            else if (CurrentView == "Enviados")
            {
                SentNotifications = await _context.Notification
                    .Where(n => n.NotificationFrom == int.Parse(userId))
                    .ToListAsync();
            }

            return Page();
        }
    }
}
