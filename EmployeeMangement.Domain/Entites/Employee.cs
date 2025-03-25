using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;
using EmployeeMangement.Domain.Enums;

namespace EmployeeMangement.Domain.Entites
{
    public class Employee
    {
        public int Id { get; set; }


        [MaxLength(50, ErrorMessage = "Max is 50 Chartacter")]
        [Display(Name = "Employee Name")]
        public string Name { get; set; }

        [Display(Name = "Salary Amount")]
        public decimal Salary { get; set; }

        public DateTime JoinDate { get; set; }

        public int  Position { get; set; }

        public int DepartmentId { get; set; } 
        public Department Department { get; set; } 
    }
}