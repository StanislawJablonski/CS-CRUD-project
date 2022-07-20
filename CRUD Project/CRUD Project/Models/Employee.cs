

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CRUD_Project.Validators;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Project.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [StringLength(50, MinimumLength = 1)]
        [Required]
        public string Name { get; set; }
        [StringLength(50, MinimumLength = 1)]
        [Required]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Please enter valid email address")]
        [EmailValidator]
        public string Email { get; set; }
        
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        
        public ICollection<Car> Cars { get; set; } 
        
        
    }
    
    
}