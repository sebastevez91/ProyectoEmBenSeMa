using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;
using SchoolMusic.Web.Data;

namespace SchoolMusic.Web.Pages.Inscrptions
{
    public class DetailsInscriptionModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;

        public DetailsInscriptionModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }

        public IList<Inscription> Inscription { get;set; } = default!;

        public async Task<IActionResult> OnGetAsync()
        {
            var userId = User.FindFirst("UserId")?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToPage("/Logins/LoginUser");
            }

            if (_context.Inscription != null)
            {
                Inscription = await _context.Inscription
                .Include(i => i.Cursada)
                .ThenInclude(c => c.Teacher)
                .Include(i => i.Student)
                .Where(i => i.Student.IdUser == int.Parse(userId))
                .ToListAsync();
            }

            return Page();
        }
    }
}
