using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Models;

namespace EmployeeManagement.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public IActionResult Dashboard()
{
    ViewData["Title"] = "/dashboard";
    return View();
}
    public IActionResult Drivers()
{
    ViewData["Title"] = "/drivers";
    return View();
}
    public IActionResult Personal_Documents()
{
    ViewData["Title"] = "/Personal_Documents";
    return View();
}
 public IActionResult Upload_documents_personal()
{
    ViewData["Title"] = "/Upload_documents_personal";
    return View();
}
 public IActionResult View_all_documents_personal()
{
    ViewData["Title"] = "/View_all_documents_personal";
    return View();
}
}
