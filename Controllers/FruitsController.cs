using Db_connection.Models;
using Microsoft.AspNetCore.Mvc;

namespace Db_connection.Controllers;

public class FruitsController : Controller
{
    private readonly ModelDbContext _dbContext;

    public FruitsController( ModelDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult Index()
    {
        var fruits = _dbContext.Fruits;
        return View(fruits);
    }

    public IActionResult Edit(int id)
    {
        var item = _dbContext.Fruits.Find(id);
        return View(item);
    }
                          
    [HttpPost]
    public IActionResult Edit(Fruits f)
    {
        _dbContext.Update(f);
        _dbContext.SaveChanges();
        return Content("edited");
    }

    public IActionResult Create()
    {
        var fruit = new Fruits();
        return View(fruit);
    }
    [HttpPost]
    public IActionResult Create(Fruits fruit)
    {
        _dbContext.Fruits.Add(fruit);
        _dbContext.SaveChanges();
        return RedirectToAction("Index");
    }

}