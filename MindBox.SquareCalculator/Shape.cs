using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MindBox.SquareCalucaltor
{
    /// <summary>
    /// Base class for shapes
    /// </summary>
    public abstract class Shape
    {
        public double GetSquare()
        {
            Validate();
            return Square;
        }

        protected abstract double Square { get; }

        public virtual void Validate()
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(this);
            if (!Validator.TryValidateObject(this, context, results, true))
            {
                var sb = new StringBuilder();
                foreach (var error in results)
                    sb.AppendLine(error.ErrorMessage);
                throw new ArgumentException(sb.ToString());
            }
        }
    }
}
