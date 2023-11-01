using Grupo7_lab1_dotnet.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            var estudios = _context.Estudios.Include(b => b.IdProfNavigation);
            return View(await _context.Estudios.ToListAsync());
        }

        public IActionResult Create()
        {
            ViewData["Profesions"] = new SelectList(_context.Profesions, "Id", "Nom");
            return View();
        }

        [HttpPost]
        public IActionResult Create(int a)
        {
            ViewData["Profesions"] = new SelectList(_context.Profesions, "Id", "Nom");
            return View();
        }
    }
}
