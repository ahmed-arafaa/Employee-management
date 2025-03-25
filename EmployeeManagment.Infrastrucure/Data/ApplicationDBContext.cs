using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeMangement.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment.Infrastrucure.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> Option):base(Option) {
        
        }
        public DbSet<Employee> Employees { get; set; } 
        public DbSet<Department> Departments { get; set; } 



    }
}
