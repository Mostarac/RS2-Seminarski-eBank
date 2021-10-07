using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eBank.Model.Helpers.CustomDataAnnotations
{
    public class IsGreaterThanINT : ValidationAttribute
    {
        private readonly string _testedPropertyName;

        public IsGreaterThanINT(string testedPropertyName)
        {
            _testedPropertyName = testedPropertyName;
        }

        public string GetErrorMessage() => $"NE RADI!";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            var propertyTestedInfo = validationContext.ObjectType.GetProperty(this._testedPropertyName);
            if (propertyTestedInfo == null)
            {
                return new ValidationResult(string.Format("unknown property {0}", this._testedPropertyName));
            }

            var propertyTestedValue = propertyTestedInfo.GetValue(validationContext.ObjectInstance, null);

            /*
            if (value == null || !(value is int))
            {
                return ValidationResult.Success;
            }

            if (propertyTestedValue == null || !(propertyTestedValue is int))
            {
                return ValidationResult.Success;
            }*/

            if ((int)value > (int)propertyTestedValue)
            {
                
                return ValidationResult.Success;
                
            }

            return new ValidationResult(GetErrorMessage());
        }
        //return base.IsValid(value, validationContext);
    }

   
}
