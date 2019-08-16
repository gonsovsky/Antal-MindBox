using System.ComponentModel.DataAnnotations;

namespace MindBox.SquareCalucaltor
{
    /// <summary>
    /// Positive range attribute for distance values
    /// </summary>
    public class PositiveAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return (double)value < 0 ?
                 new ValidationResult(
                    $"{validationContext.DisplayName} {(double)value} must be greater than zero")
            :  null;
        }
    }
}
