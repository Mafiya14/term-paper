using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using term_paper.Models;

namespace term_paper.Controllers
{
    public class HomeController : Controller
    { 
        StudyContext studyContext = new StudyContext();
    
        public IActionResult Index()
        {
            // извлекаем данные из таблицы Study
            IEnumerable<Student> students = studyContext.Students;

            // записываем students в динамическое свойство ViewBag
            ViewBag.Students = students;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

      
    }
}
