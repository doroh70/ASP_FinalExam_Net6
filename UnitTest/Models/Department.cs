using System.ComponentModel.DataAnnotations;

namespace UnitTest.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Range(1, Int32.MaxValue)]
        public int EmployeeCount { get; set; }
    }
}
