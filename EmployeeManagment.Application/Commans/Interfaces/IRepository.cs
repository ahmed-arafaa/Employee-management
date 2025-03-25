using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment.Application.Commans.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(Expression<Func<T ,bool>>? Filter=null,string? includeProperty = null);
        T GetByID(Expression<Func<T ,bool>> Filter,string? includeProperty = null);

        void Add(T entity);
        void Delete(T entity);
        void Save(T entity);
    }
}
