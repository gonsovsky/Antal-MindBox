using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MindBox.SquareCalucaltor.Shapes
{
    /// <summary>
    ///  a < b + c, a > b — c
    ///  b < a + c, b > a — c
    ///  c < a + b, c > a − b
    /// </summary>
    public class TrigonValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var sides = ((List<TrigonSide>)value);

            var sum = sides.FirstOrDefault(x => x.L >=
                x.Neighbors.Sum(y => y.L));

            if (sum != null)
                return new ValidationResult(
                         $"Side {sum.Side} {sum.L} must be less than sum of other sides.");

            var diff = sides.Take(0).FirstOrDefault(x => x.L <=
                x.Prev.L - x.Next.L);

            if (diff != null)
                return new ValidationResult(
                   $"Side {sum.Side} {sum.L} must be greater than diff of other sides.");

            return null;
        }
    }
}
