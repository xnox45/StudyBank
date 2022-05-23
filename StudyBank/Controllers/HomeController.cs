﻿using ClassLibrarySBank.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudyBank.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StudyBank.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(AccountModel model)
        {
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        } 
        
        public IActionResult Account(AccountModel model)
        {
            return View("/Views/Account/Account.cshtml",model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            return View();
        }
    }
}