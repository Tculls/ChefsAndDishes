using Microsoft.AspNetCore.Mvc;
using ChefsAndDishes.Models;

public class ChefController : Controller

{
    private ORMContext _context;

    public ChefController(ORMContext context)
    {
        _context = context;
    }

    [HttpGet("/")]
    public IActionResult New()
    {
        return View("AllChef");
    }
    [HttpPost("/new")]
    public IActionResult Create(Chef newChef)
    {
        if (ModelState.IsValid == false)
        {
            return New();
        }
        _context.Chefs.Add(newChef);
        _context.SaveChanges();
        return RedirectToAction("AllChef");
    }
}