using Microsoft.AspNetCore.Mvc;
using ChefsAndDishes.Models;
using Microsoft.EntityFrameworkCore;

public class ChefController : Controller

{
    private ORMContext _context;

    public ChefController(ORMContext context)
    {
        _context = context;
    }

    [HttpGet("/")]
    public IActionResult AllChef()
    {
        List<Chef> allChefs = _context.Chefs.Include(piss => piss.Dishes).ToList();

        return View("AllChef", allChefs);
    }
    [HttpPost("/AddChef")]
    public IActionResult CreateChef(Chef newChef)
    {
        if (ModelState.IsValid == false)
        {
        return View("NewChef");
        }
        else
        {           
        _context.Chefs.Add(newChef);
        _context.SaveChanges();
        
        return RedirectToAction("AllChef");
        }
    }
    [HttpGet("/new")]
    public IActionResult AddChef()
    {
        return View("NewChef");
    }

}