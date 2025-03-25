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
    public class DepartmentReprosatory : Repository<Department>, IDepartmentRepository
    {
        public DepartmentReprosatory(ApplicationDBContext context):base(context) 
        {
            
        }
        public void Update(Department department)
        {
           _Set.Update(department);
        }
    }
}
