using Microsoft.AspNetCore.Mvc;
using ChefsAndDishes.Models;

public class ChefController : Controller

{
    private ORMContext _context;

    public ChefController(ORMContext context)
    {
        _context = context;
    }

    [HttpGet("/All")]
    public IActionResult AllChef()
    {
        List<Chef> allChefs = _context.Chefs.ToList();

        return View("AllChef", allChefs);
    }
    [HttpPost("/new")]
    public IActionResult Create(Chef newChef)
    {
        if (ModelState.IsValid == false)
        {
            return AllChef();
        }
        _context.Chefs.Add(newChef);
        _context.SaveChanges();
        return RedirectToAction("AllChef");
    }

}