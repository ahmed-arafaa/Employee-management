using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagment.Application.Commans.Interfaces;
using EmployeeManagment.Infrastrucure.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment.Infrastrucure.Reprosatories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public  ApplicationDBContext _mYDBContext;
        public  DbSet<T> _Set;

        public Repository(ApplicationDBContext Context)
        {
            _mYDBContext = Context;
            _Set = _mYDBContext.Set<T>();
        }

        void IRepository<T>.Add(T entity)
        {
            _mYDBContext.Add(entity);
            _mYDBContext.SaveChanges();
        }

        void IRepository<T>.Delete(T entity)
        {
            _mYDBContext.Remove(entity);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? Filter, string? includeProperty)
        {
            IQueryable<T> Entities = _Set;
            if (Filter != null)            
                Entities = Entities.Where(Filter);
            
            if (!string.IsNullOrEmpty(includeProperty))
            {
                foreach (var item in includeProperty.Split(new char[] {','},StringSplitOptions.RemoveEmptyEntries))
                {
                    Entities = Entities.Include(item);
                }
            }

            return Entities.ToList();
        }

        public  T GetByID(Expression<Func<T, bool>> Filter, string? includeProperty)
        {
            IQueryable<T> Entities = _Set;
            if (Filter != null)
                Entities = Entities.Where(Filter);

            if (!string.IsNullOrEmpty(includeProperty))
            {
                foreach (var item in includeProperty.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    Entities = Entities.Include(item);
                }
            }

            return Entities.FirstOrDefault();
        }

        public void Save(T entity)
        {
            _mYDBContext.SaveChanges(); 
        }
    }
}
