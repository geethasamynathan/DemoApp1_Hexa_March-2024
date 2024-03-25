using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DemoApp1.Models
{
    public class Employee
    {
        [DisplayName("Employee Id")]
        [Required]
        [Range(101,150)]
        public int EmployeeId { get; set; }
        [Required]
        [StringLength(maximumLength:40,MinimumLength =3, ErrorMessage ="Name spuld have 3-40 chars length")]
        public string EmployeeName { get; set; }
        public string Gender { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOJ { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
