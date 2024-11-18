using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;

namespace SchoolMusic.Web.Pages.Cursadas
{
    public class DetailsModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;

        public DetailsModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }

        public IList<Cursada> Cursadas { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync()
        {
            var userId = User.FindFirst("UserId")?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToPage("/Logins/LoginUser");
            }

            Cursadas = await _context.Cursada
                                    .Include(c => c.Teacher)
                                    .Include(c => c.Course)
                                    .Where(c => c.Teacher.IdUser == int.Parse(userId))
                                    .ToListAsync();


            return Page();
        }
    }
}
