using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;

namespace SchoolMusic.Web.Pages.Tablons
{
    public class PostDetailsModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;

        public PostDetailsModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }
        public Topic Topic { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var topics = await _context.Topic
                .Include(c => c.Coments)
                .Where(c => c.IdTopic == id)
                .FirstOrDefaultAsync();

            if (topics == null)
            {
                return NotFound();
            }

            Topic = topics;
            return Page();
        }

        [BindProperty]
        public Coment Coment { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Coment == null || Coment == null)
            {
                return Page();
            }

            _context.Coment.Add(Coment);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Tablons/PostDetails", new { id = Coment.IdTopic });
        }
    }
}
