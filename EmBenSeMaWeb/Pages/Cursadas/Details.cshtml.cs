using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;
using SchoolMusic.Web.Data;

namespace SchoolMusic.Web.Pages.Cursadas
{
    public class DetailsModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;

        public DetailsModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }

        public Cursada Cursada { get; set; } = default!; 
        public Course Course { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Cursada == null)
            {
                return NotFound();
            }

            var cursada = await _context.Cursada.Include(t => t.Teacher)
                .FirstOrDefaultAsync(m => m.IdCursada == id);
            if (cursada == null)
            {
                return NotFound();
            }
            else 
            {
                Cursada = cursada;
                var curso = await _context.Course.FirstOrDefaultAsync(m => m.IdCourse == Cursada.IdCourse);
                if (curso == null)
                {
                    return NotFound();
                }
                else
                {
                    Course = curso;
                }
            }
            return Page();
        }
    }
}
