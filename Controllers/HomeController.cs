using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace basics.Controllers;

public class HomeController : Controller // un
{
    public string Index()
    {
        return "home/index";
    }

    public string Contact()
    {
        return "home/contact";
    }
}
