using Microsoft.AspNetCore.Mvc;
using Site.Db;

namespace Site.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult CreateStud()
        {
            return View();
        }

        private readonly ApplicationDbContext _context;

        public StudentsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult CheckConnection()
        {
            bool canConnect = _context.Database.CanConnect();

            if (canConnect)
                return Content("Успешное подключение к базе данных");
            else
                return Content("Не удалось подключиться к базе данных");
        }

    }
}
