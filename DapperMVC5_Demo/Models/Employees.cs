using System;
using System.ComponentModel.DataAnnotations;

namespace DapperMVC5_Demo.Models
{
    public class Employees
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public string Office { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public int Salary { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        public Departments Departments { get; set; }
    }
}