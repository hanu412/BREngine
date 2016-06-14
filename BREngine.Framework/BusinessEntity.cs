using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using  System;

namespace BREngine.Framework
{
    public class BusinessEntity
    {
        public string KeyIdentifier { get; set; }

        public bool IsValid()
        {

            return !GetValidationResults().Any();
        }

        

        protected virtual IEnumerable<ValidationResult> GetValidationResults()
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(this, serviceProvider: null, items: null);
            bool isValid = Validator.TryValidateObject(
             this, context, results, true);
            return results;
        }



    }


}
