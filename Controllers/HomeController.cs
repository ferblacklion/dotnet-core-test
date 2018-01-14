﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc_test.Models;

namespace mvc_test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string id = "html")
        {

            if (id == "json") {
                return Json(new { Id = 0, Name = "asdf" });
            }

            if (id == "img") {
                var file = System.IO.File.ReadAllBytes(@"C:\Users\miguelr\Pictures\19_Suicide-Squad.jpg");
                return File(file, "image/jpeg");
            }

            if (id == "text") {
                return Content("1,2", "text/csv");
            }

            return View();
        }

        private string Test() {
            return "Hola AW";
        }

        public IActionResult Blog(int year, int month, int day) {
            return Content($"{year}/{month}/{day}");
        }

        public IActionResult BlogArticle(string category, string subcategory, string article) {
            return Content($"{category}/{subcategory}/{article}");
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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Hello(string name) {
            return Content($"{name}");
        }
    }
}
