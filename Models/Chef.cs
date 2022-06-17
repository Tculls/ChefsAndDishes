#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
public class Chef
{
    [Key]
    public int ChefId {get; set; }

    [Required]
    [MinLength(2, ErrorMessage = "Insert First Name")]
    public string FirstName {get; set; }

    [Required]
    [MinLength(2, ErrorMessage ="Insert Last Name")]
    public string LastName {get; set; }

    [Required]
    [DateValidations(ErrorMessage =" Poingo ssa")]
    public DateTime BirthDate {get; set; }

    public List<Dish> Dishes {get; set; } = new List<Dish>();
    public DateTime CreatedAt {get; set; } = DateTime.Now;
    public DateTime UpdatedAt {get; set; } = DateTime.Now;
}