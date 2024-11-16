using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;
using SchoolMusic.Web.Data;

namespace SchoolMusic.Web.Pages.Tablons
{
    public class indexModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;

        public indexModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }

      public Tablon Tablon { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Tablon == null)
            {
                return NotFound();
            }

            var tablon = await _context.Tablon.FirstOrDefaultAsync(m => m.idCursada == id);
            if (tablon == null)
            {
                return Page();
            }
            else 
            {
                Tablon = tablon;
            }
            return Page();
        }
    }
}
