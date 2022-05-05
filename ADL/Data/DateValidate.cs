using System;
using System.ComponentModel.DataAnnotations;

namespace ADL.Data
{
    public class DateValidate : ValidationAttribute
    {
        public DateValidate() { }

        public string GetErrorMessage() => "Date must be at least 2 days in the future";

        protected override ValidationResult? IsValid(object value, ValidationContext validationContext)
        {
            var date = (DateTime)value;
            if (DateTime.Compare(date, DateTime.Now.Date.AddDays(2)) < 0)
            {
                return new ValidationResult(GetErrorMessage());
            }
            else {
                return ValidationResult.Success;
            } 
        }

    }


}
