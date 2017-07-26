using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectMvc_DOMAIN
{
   public interface IRepository<T>
    {
        void Insert(T entity);
        void Delete(Object Id);
        int Save();
        IEnumerable<T> GetList();
        IQueryable<T> GetListQuerable();
        IEnumerable<T> GetList(Expression<Func<T, bool>> _lambda);
        T FirstOrDefault(Expression<Func<T, bool>> _lamda); //  Herhangi bir nesenyi herhangi bir 
        
         //degerle aramak için kullanılır. 
        bool Any(Expression<Func<T, bool>> _lambda);
        
    }
}
