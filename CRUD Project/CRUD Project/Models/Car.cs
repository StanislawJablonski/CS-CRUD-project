

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Project.Models
{
    public class Car
    {
        public int CarId { get; set; }
        [StringLength(50, MinimumLength = 1)]
        [Required]
        public string Model { get; set; }
        [StringLength(50, MinimumLength = 1)]
        [Required]
        public string Producer { get; set; }
        
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Required]
        public decimal Price { get; set; }
        
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        
        
    }
}