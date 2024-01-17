using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Microsoft.EntityFrameworkCore;

namespace Site.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Students.ToListAsync());
        }

        public IActionResult CreateStud()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateStud([Bind("id,Фамилия,Имя,Отчество,Рост,День_Рождения,Группа,Специальность,Стипендия")] Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
    }
}
