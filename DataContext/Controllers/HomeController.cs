using DataContext.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataContext.Controllers
{
    public class HomeController:Controller
    {
        private readonly Context _context;
        public HomeController(Context context)
        {
            _context = context;    
        }

        public IActionResult Index()
        {

            var stuList = _context.Students.ToList();
            //_context.Students.Add();
            //_context.Students.Remove();
            //_context.Students.Update();

            return View(stuList);
        }
    }
   
}
