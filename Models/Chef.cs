#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
public class Chef
{
    [Key]

    public int ChefId {get; set ;}

    [Required]
    [MinLength(2, ErrorMessage = "Insert First Name")]
    public string FirstName {get; set; }

    [Required]
    [MinLength(2, ErrorMessage ="Insert Last Name")]
    public string LastName {get; set; }

    [Required]
    [DateValidations]
    public int BirthDate {get; set; }

    public DateTime CreatedAt {get; set; } = DateTime.Now;
    public DateTime UpdatedAt {get; set; } = DateTime.Now;
}