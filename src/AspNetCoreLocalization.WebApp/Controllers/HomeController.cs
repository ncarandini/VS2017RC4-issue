using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreLocalization.WebApp.Data;
using AspNetCoreLocalization.WebApp.Models.HomeViewModels;

namespace AspNetCoreLocalization.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string msg = null)
        {
            return View();
        }

        // GET: Home/Create
        public IActionResult Create()
        {
            var createItemViewModel = new CreateItemViewModel
            {
                Quantity = 1,
                UnitPrice = 1.00M,
                StartDate = DateTimeOffset.Now,
                EndDate = DateTimeOffset.Now.AddDays(180)
            };
            return View(createItemViewModel);
        }

        // POST: Sellers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,Description,Quantity,UnitPrice,StartDate,EndDate")] CreateItemViewModel createItemViewModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", new { msg = "Item created."});
            }
            return View(createItemViewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }


    }
}
