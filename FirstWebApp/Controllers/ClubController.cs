﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebApp.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstWebApp.Controllers
{
    public class ClubController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClubController(ApplicationDbContext context) 
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Models.Club> clubs = _context.Clubs.ToList();
            return View(clubs);
        }
    }
}

