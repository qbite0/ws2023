using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SecurePro.Models;

namespace SecurePro.Controllers;

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
    
    [HttpPost]
    public Task Ticket()
    {
        Response.ContentType = "text/html; charset=utf-8";
        
        var form = Request.Form;
        
        return Response.WriteAsync($"<div><p>Имя: {form["firstname"]}</p>" +
                                   $"<p>Фамилия: {form["lastname"]}</p>" +
                                   $"<div>Отчество:{form["patronymic"]}</div></div>");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}