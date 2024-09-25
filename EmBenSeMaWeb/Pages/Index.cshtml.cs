using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmBenSeMaWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;

        public IndexModel(ILogger<IndexModel> logger, SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {

        }
    }
}
