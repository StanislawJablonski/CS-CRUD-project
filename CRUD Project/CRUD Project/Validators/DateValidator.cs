using System;
using System.ComponentModel.DataAnnotations;

namespace CRUD_Project.Validators
{
    public class DateValidator : ValidationAttribute
    {
        public override bool IsValid(object value) {
            try {
                DateTime date = Convert.ToDateTime(value);
                return date <= DateTime.Now;
            }
            catch { return false; }
        }
    }
}