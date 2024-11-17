using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SchoolMusic.Entidades;

namespace SchoolMusic.Web.Pages.Notifications
{
    public class CreateNotificationModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;

        public CreateNotificationModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Notification Notification { get; set; } = new Notification();
        public int IdTo { get; set; }
        public async Task<IActionResult> OnGetAsync(int idTo)
        {
            var userId = User.FindFirst("UserId")?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToPage("/Logins/LoginUser");
            }

            if(idTo != null)
            {
                IdTo = idTo;
            }
            
            Notification.NotificationFrom = int.Parse(userId);
            Notification.NotificationTo = IdTo;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Notification.DateNotification = DateTime.Now;

            if (!ModelState.IsValid || _context.Notification == null || Notification == null)
            {
                return Page();
            }

            _context.Notification.Add(Notification);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Notifications/IndexNotification");
        }
    }
}
