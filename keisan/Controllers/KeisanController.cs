using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace keisan.Controllers
{
    public class KeisanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
