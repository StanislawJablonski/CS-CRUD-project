
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CRUD_Project.Validators;
using Microsoft.EntityFrameworkCore;


namespace CRUD_Project.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        [StringLength(50, MinimumLength = 1)]
        [Required]
        public string Name { get; set; }
        
        [DataType(DataType.Date)] 
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of creation")]
        [DateValidator]
        [Required]
        public DateTime DateOfCreation { get; set; }
        
        public Address Address { get; set; }
        public ICollection<Employee> Employees { get; set; } 
        
        
    }


}