﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio_Core.Controllers
{
    public class DashboardController : Controller
      
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
