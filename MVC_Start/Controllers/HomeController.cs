using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Start.Models;

namespace MVC_Start.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
            int x = 3;
            int y = 4;
            int z = x + y;

      return View();
    }

    public IActionResult IndexWithLayout()
    {
     return View();
    }
  }
}