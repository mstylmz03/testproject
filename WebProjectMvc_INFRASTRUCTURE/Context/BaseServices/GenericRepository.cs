using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebProjectMvc_DOMAIN;
using WebProjectMvc_DOMAIN.Model;
using WebProjectMvc_INFRASTRUCTURE.Context;

namespace WebProjectMvc_INFRASTRUCTURE.BaseServices
{
   public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity:BaseEntity
    {
        protected DbContext _context;
        public GenericRepository()
        {
            _context = new ApplicationDbContext();
        }
        public bool Any(Expression<Func<TEntity, bool>> _lambda)
        {
            return _context.Set<TEntity>().Any(_lambda);
        }
        public void Delete(object Id)
        {
            var entity = _context.Set<TEntity>().Find(Id);
            if (entity != null)
            {
                entity.IsActive = false;
                entity.IsDeleted = true;
            }
        }
        public TEntity FirstOrDefault(System.Linq.Expressions.Expression<Func<TEntity, bool>> _lamda)
        {
            return _context.Set<TEntity>().FirstOrDefault(_lamda);
        }
        public IEnumerable<TEntity> GetList()
        {
            return _context.Set<TEntity>().Where(x => x.IsActive && !x.IsDeleted).AsEnumerable();
        }
        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> _lambda)
        {
            return _context.Set<TEntity>().Where(x => x.IsActive && !x.IsDeleted).Where(_lambda).AsEnumerable();
        }
        public IQueryable<TEntity> GetListQuerable()
        {
            return _context.Set<TEntity>().Where(x => x.IsActive && !x.IsDeleted).AsQueryable();
        }
        public void Insert(TEntity entity)
         {
            entity.IsActive = true;
            _context.Set<TEntity>().Add(entity);
        }
        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
