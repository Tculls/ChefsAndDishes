using Microsoft.AspNetCore.Mvc;
using ChefsAndDishes.Models;

public class DishController : Controller
{
    private ORMContext _context;

    public DishController(ORMContext context)
    {
        _context = context;
    }

    [HttpGet("/dishes")]
    public IActionResult New()
    {
        return View("AllDish");
    }
    [HttpPost("dishes/new")]
    public IActionResult Create(Dish newDish)
    {
        if (ModelState.IsValid == false)
        {
            return View("AllDish");
        }
        _context.Dishes.Add(newDish);
        _context.SaveChanges();

        return RedirectToAction("AllDish");
    }
}