using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile
{
    public static class ObjectValidator
    {
        public static IEnumerable<ValidationResult> Validate ( object value )
        {

            var context = new ValidationContext(value);
            var results = new Collection<ValidationResult>();
            Validator.TryValidateObject(value, context, true);

            return errors;
        }
    }
}
