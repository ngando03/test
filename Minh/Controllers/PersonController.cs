using Microsoft.AspNetCore.Mvc;
using minh.Models;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class PersonControll : Controller
    {
        public IActionResult Index()
        {
            return View();
        
        }
        [HttpPost]
        public IActionResult Index(Person ps)
{
        }
    }      
        
    }
