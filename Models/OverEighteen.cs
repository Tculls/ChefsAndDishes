
using System.ComponentModel.DataAnnotations;
public class OverEighteen : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext context)
    {
        DateTime _dateJoin = Convert.ToDateTime(value);
        if (_dateJoin.AddYears(18) < DateTime.Now)
        {
            return ValidationResult.Success;
        }
        else
        {
            return new ValidationResult("must be 18 years or older");
        }
    }
}