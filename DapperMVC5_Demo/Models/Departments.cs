using System.ComponentModel.DataAnnotations;

namespace DapperMVC5_Demo.Models
{
    public class Departments
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string DepartmentName { get; set; }
    }
}