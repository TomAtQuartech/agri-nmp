﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using SERVERAPI.Models;
using SERVERAPI.ViewModels;

namespace SERVERAPI.Controllers
{
    public class SoilController : Controller
    {
        private IHostingEnvironment _env;

        public SoilController(IHostingEnvironment env)
        {
            _env = env;
        }
        [HttpGet]
        public IActionResult SoilTests()
        {
            var farmData = HttpContext.Session.GetObjectFromJson<FarmData>("FarmData");
            Models.Impl.StaticData sd = new Models.Impl.StaticData();

            FarmViewModel fvm = new FarmViewModel();

            return View(fvm);
        }
        [HttpPost]
        public IActionResult SoilTests(FarmViewModel fvm)
        {

            return View(fvm);
        }
    }
}