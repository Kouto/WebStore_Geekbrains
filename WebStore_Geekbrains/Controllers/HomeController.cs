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
    }
}