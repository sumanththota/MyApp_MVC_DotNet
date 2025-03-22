using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    //Add async to the method to make it asynchronous as we are fetching data from the database
    // task is a class that represents an asynchronous operation
    //It will make sures that the method is executed in a separate thread
    //it will wait for the result to be returned
    public async Task<IActionResult> Index()
    {
        var item = await _context.Items.ToListAsync();
        return View(item);
    }
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create([Bind("Id, Name, Price, Quantity")] Item item)
    {
        if (ModelState.IsValid)
        {
            _context.Items.Add(item);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        return View(item);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var item = await _context.Items.FirstOrDefaultAsync(x => x.Id == id);
        return View(item);
    }
    [HttpPost]
    public async Task<IActionResult> Edit([Bind("Id,Name,Price,Quantity")] Item item)
    {
        if (ModelState.IsValid)
        {
            _context.Items.Update(item);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        return View(item);
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        var item = await _context.Items.FirstOrDefaultAsync(x => x.Id == id);
        return View(item);
    }
    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var item = await _context.Items.FindAsync(id);
        if (item != null)
        {
            _context.Items.Remove(item);
            await _context.SaveChangesAsync();
        }
        return RedirectToAction("Index");
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