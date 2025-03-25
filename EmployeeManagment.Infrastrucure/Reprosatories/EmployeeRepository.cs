using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagment.Application.Commans.Interfaces;
using EmployeeManagment.Infrastrucure.Data;
using EmployeeMangement.Domain.Entites;

namespace EmployeeManagment.Infrastrucure.Reprosatories
{
    public class EmployeeRepository:Repository<Employee>,IEmployeeRepository
    {
        
        public EmployeeRepository(ApplicationDBContext context ):base(context)
        {
                
        }

        public void Update(Employee employee)
        {
            _Set.Update( employee);
        }
    }
}
