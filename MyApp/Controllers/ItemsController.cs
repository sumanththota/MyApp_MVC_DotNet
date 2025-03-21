using Microsoft.AspNetCore.Mvc;
using MyApp.Models;

namespace MyApp.Controllers;

public class ItemsController : Controller
{
    // GET
    public IActionResult Overview()
    {
        var item = new Item() { Name = "keyboard" };
        return View(item);
    }
}