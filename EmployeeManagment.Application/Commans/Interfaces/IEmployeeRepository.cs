using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeMangement.Domain.Entites;

namespace EmployeeManagment.Application.Commans.Interfaces
{
    public interface IEmployeeRepository:IRepository<Employee>
    {
        void Update(Employee employee);
    }
}
