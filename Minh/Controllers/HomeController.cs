using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Minh.Models;

namespace Minh.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string FullName, string Address)
    {
    string str0utput = "Xin chào"+ FullName + "đến từ" + Address;
    ViewBag.Massage = str0utput;
    return View();
    }
}