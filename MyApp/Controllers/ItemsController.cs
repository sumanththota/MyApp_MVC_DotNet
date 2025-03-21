using Microsoft.AspNetCore.Mvc;
using MyApp.Data;
using MyApp.Models;

namespace MyApp.Controllers;

public class ItemsController : Controller
{
    
    
    private readonly MyAppContext _context;
    //Dependency injection
    public ItemsController(MyAppContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var item = _context.Items.ToList();
        return View();
    }
    
}









// // GET
// public IActionResult Overview()
// {
//     var item = new Item() { Name = "keyboard" };
//     return View(item);
// }
// public IActionResult edit(int id)
// {
//
//     return Content("id = " + id);
// }