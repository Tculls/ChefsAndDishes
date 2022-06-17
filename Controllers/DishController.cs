using Microsoft.AspNetCore.Mvc;
using ChefsAndDishes.Models;
using Microsoft.EntityFrameworkCore;

public class DishController : Controller
{
    private ORMContext _context;

    public DishController(ORMContext context)
    {
        _context = context;
    }

    [HttpGet("/dishes")]
    public IActionResult AllDish()
    {
        List<Dish> allDishes = _context.Dishes.Include(piss => piss.Creator).ToList();
        return View("AllDish", allDishes);
    }
    [HttpPost("AddDish")]
    public IActionResult CreateDish(Dish newDish)
    {
        if (ModelState.IsValid == false)
        {
            return AddDish();
            
        }
        
            _context.Dishes.Add(newDish);
            _context.SaveChanges();
        return RedirectToAction("AllDish");
    }
    [HttpGet("/dishes/new")]
    public IActionResult AddDish()
    {
        List<Chef> allChefs = _context.Chefs.ToList();
        ViewBag.allChefs = allChefs;
        return View("NewDish");
    }
}