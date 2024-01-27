using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace basics.Controllers;

public class CourseController: Controller {
    public IActionResult Index()
    {
        var kurs = new Course();
        kurs.Id = 1;
        kurs.Title = "Aspnet core kursu";
        kurs.Description = "guzel bir kurs";
        return View(kurs);
    }

    public IActionResult List()
    {
        return View();
    }

}