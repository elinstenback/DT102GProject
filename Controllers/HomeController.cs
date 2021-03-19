using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DT102GProject.Models;
using Microsoft.AspNetCore.Authorization;
using DT102GProject.Data;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;

namespace DT102GProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.Course = await _context.Course.ToListAsync();
            mymodel.FAQ = await _context.FAQ.ToListAsync();

            return View(mymodel);
        }

        public async Task<IActionResult> Courses()
        {
            return View(await _context.Course.ToListAsync());
        }

        public IActionResult About()
        {
            return View();
        }

        public async Task<IActionResult> FAQ()
        {
            return View(await _context.FAQ.ToListAsync());
        }

        [Authorize]
        public IActionResult Admin()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
