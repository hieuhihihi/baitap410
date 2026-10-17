using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace quanlysv.Models
{
    public class ValidationHelper
    {
        public static bool Validate(object obj, out List<ValidationResult> results)
        {
            var context = new ValidationContext(obj);

            results = new List<ValidationResult>();

            return Validator.TryValidateObject(
                obj,
                context,
                results,
                true
            );
        }
    }
}