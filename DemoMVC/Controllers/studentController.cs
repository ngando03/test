using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers{
    public class Hello :Controller{
        public IActionResult Index(){
            return View();
        }
    }
}