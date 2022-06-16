#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;
namespace ChefsAndDishes.Models;

public class ORMContext : DbContext
{
    public ORMContext(DbContextOptions options) : base(options){  }

    public DbSet<Dish> Dishes {get;  set; }
    public DbSet<Chef> Chefs {get; set; }
}