using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;
using SchoolMusic.Web.Data;

namespace SchoolMusic.Web.Pages.Notifications
{
    public class IndexNotificationModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;

        public IndexNotificationModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }

        public IList<Notification> NotificacionesRecibidas { get;set; } = default!;
        public IList<Notification> NotificacionesEnviadas { get; set; } = default!;
        public Users UserSesion { get; set; } = default!;

        public async Task OnGetAsync(int? CurrentUserId)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.IdUser == CurrentUserId);
            if(user != null)
            {
                UserSesion = user;
            }
            // Cargar notificaciones recibidas y enviadas
            NotificacionesRecibidas = await _context.Notification
                .Where(n => n.NotificationTo == CurrentUserId)
                .ToListAsync();

            NotificacionesEnviadas = await _context.Notification
                .Where(n => n.NotificationFrom == CurrentUserId)
                .ToListAsync();
        }
    }
}
