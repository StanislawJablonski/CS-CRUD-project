using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace CRUD_Project.Validators
{
    public class EmailValidator : ValidationAttribute
    {
        public override bool IsValid(object value) {
            string email = Convert.ToString(value);
            Regex rx = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            return rx.IsMatch(email);
        }
    }
}