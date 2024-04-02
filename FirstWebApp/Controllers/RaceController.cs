using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebApp.Data;
using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstWebApp.Controllers
{
    public class RaceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RaceController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Race> races = _context.Races.ToList();
            return View(races);
        }
    }
}

