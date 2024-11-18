using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;
using SchoolMusic.Web.Data;

namespace SchoolMusic.Web.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;

        public IndexModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }
        public IList<Inscription> Inscriptions { get;set; } = default!;

        public async Task OnGetAsync(int? id)
        {
            var incriptiones = await _context.Inscription
                .Include(x => x.Student)
                .Where(c => c.idCursada == id)
                .ToListAsync();
            if (incriptiones != null)
            {
                Inscriptions = incriptiones;
            }
        }
    }
}
