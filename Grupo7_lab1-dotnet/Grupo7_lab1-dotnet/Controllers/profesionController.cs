using Grupo7_lab1_dotnet.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Grupo7_lab1_dotnet.Controllers
{
    public class profesionController : Controller
    {
        private readonly PersonaDbContext _context;

        public profesionController( PersonaDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Profesions.ToListAsync());
        }
    }
}
