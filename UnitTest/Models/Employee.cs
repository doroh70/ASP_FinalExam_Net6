using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnitTest.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public bool IsManager { get; set; }
        [Key, ForeignKey("Departments")]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
