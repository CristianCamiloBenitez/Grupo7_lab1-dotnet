using Grupo7_lab1_dotnet.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Grupo7_lab1_dotnet.Controllers
{
    public class estudiosController : Controller
    {

        private readonly PersonaDbContext _context;

        public estudiosController(PersonaDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var estudios = _context.Estudios.Include(b => b.IdProf);
            return View(await _context.Estudios.ToListAsync());
        }
    }
}
