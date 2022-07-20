
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Project.Models
{ public class Address : IValidatableObject
    {
        public int AddressId { get; set; }
        [StringLength(50, MinimumLength = 1)]
        [Required]
        public string City { get; set; }
        [StringLength(50, MinimumLength = 1)]
        [Required]
        public string Street { get; set; }
        [Display(Name = "Street number")]
        [StringLength(20, MinimumLength = 1)]
        [Required]
        public string StreetNumber { get; set; }
        [Display(Name = "Flat number")]
        [Required]
        public string FlatNumber { get; set; }
        
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        
        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (City == "Gdańsk" && Int32.Parse(StreetNumber) < 1 || Int32.Parse(StreetNumber) > 1000)
            {
                yield return new ValidationResult("Street numbers in Gdańsk must be in (1,1000).",
                new []{nameof(StreetNumber)});
            }
        }
        
        
    }
    
}