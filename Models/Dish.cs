#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;

public class Dish
{
    [Key]
    public int DishId{get; set; }

    [Required]
    [MinLength(2, ErrorMessage = "Insert name of dish")]
    public string DishName {get; set; }

    [Required]
    [Range(1, 10000, ErrorMessage = "Please insert calories")]
    public int Calories {get; set; }

    [Required]
    [MinLength(20, ErrorMessage = "Please leave a brief description")]
    public string Description {get; set; }

    [Required]
    [Range(1,5, ErrorMessage = "Please indicate tastiness")]
    public int Tastiness {get; set; }

    public int ChefId {get; set; }
    public Chef Creator {get; set; }
    public DateTime CreatedAt {get; set; } = DateTime.Now;
    public DateTime UpdatedAt {get; set; } = DateTime.Now;
}