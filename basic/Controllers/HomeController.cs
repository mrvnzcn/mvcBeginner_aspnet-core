using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace basics.Controllers;

public class HomeController : Controller // un
{
    public IActionResult Index()
    {
        return View(Repository.Courses);
    }

    public IActionResult Contact()
    {
        return View();
    }
}
