using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;

namespace SchoolMusic.Web.Pages.Courses
{
    public class InfoCourseModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;
        public InfoCourseModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }
        public IList<Teacher> Teacher { get; set; } = default!;
        public IList<Cursada> Cursadas { get; set; } = default!;

        public Course Course { get; set; } = default!;
        public Users UserSesion {  get; set; }

        public async Task OnGetAsync(int? idUser,int idCourse)
        {
            if(idUser != null)
            {
                UserSesion = await _context.Users.FirstOrDefaultAsync(u => u.IdUser == idUser);
            }

            Course = await _context.Course.FirstOrDefaultAsync(m => m.IdCourse == idCourse);


            // Obtén todos los registros de 'Cursada' relacionados con el 'idCourse'
            Cursadas = await _context.Cursada
                                     .Include(c => c.Teacher)
                                     .Where(c => c.IdCourse == idCourse) // Filtrar por el ID del curso
                                     .ToListAsync();

            // Extraer los profesores de las cursadas y almacenarlos en la lista Teacher
            Teacher = Cursadas.Select(c => c.Teacher).Distinct().ToList();
        }
    }
}
