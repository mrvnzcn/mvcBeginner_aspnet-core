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
        var kurslar = new List<Course>()
        {
            new Course() {Id=1, Title="aspnet kursu", Description="guzel bir kurs"},
            new Course() {Id=2, Title="php kursu", Description="guzel bir kurs"},
            new Course() {Id=3, Title="django kursu", Description="guzel bir kurs"},
            new Course() {Id=4, Title="javascript kursu", Description="guzel bir kurs"}
        };
        return View("CourseList", kurslar);
    }

}