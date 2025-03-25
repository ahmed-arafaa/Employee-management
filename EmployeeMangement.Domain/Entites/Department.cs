using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangement.Domain.Entites
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        
        [MaxLength(50,ErrorMessage ="Max is 50 Chartacter")]
        [Display(Name ="Department Name")]
        public string? Name { get; set; }

        List<Employee> Employees { get; set; } 
        
    }
}
