﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebStore_Geekbrains.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult Error404()
        {
            return View();
        }    
        public IActionResult BlogSingle()
        {
            return View();
        }
    }
}