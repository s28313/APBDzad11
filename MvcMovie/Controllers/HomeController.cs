using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Diagnostics;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        // 
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
    }
