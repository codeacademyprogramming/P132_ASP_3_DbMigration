using Eterna.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Eterna.Controllers
{
    public class ServiceController : Controller
    {

        private readonly EternaDbContext _context;
        public ServiceController(EternaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Services.ToList());
        }

        public IActionResult Detail(int id)
        {
            Service service = _context.Services.ToList().Find(x => x.Id == id);

            return View(service);
        }
    }
}
