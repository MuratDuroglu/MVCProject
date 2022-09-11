using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate.Repositories
{
    public class EfEntityRepositoryBase<TEntity, TContex> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContex : DbContext, new()
    {
      
        public void Add(TEntity entity)
        {
            using (TContex context = new TContex())
            {
                //context.Configuration.AutoDetectChangesEnabled = false;
                //context.Configuration.LazyLoadingEnabled = false;
                //context.Configuration.ProxyCreationEnabled = false;
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
               
                context.SaveChanges();
            }
        }
       

        public void Delete(TEntity entity)
        {
            using (TContex context = new TContex())
            {
                //context.Configuration.AutoDetectChangesEnabled = false;
                //context.Configuration.LazyLoadingEnabled = false;
                context.Configuration.ProxyCreationEnabled = false;
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContex context = new TContex())
            {
                context.Configuration.AutoDetectChangesEnabled = false;
                context.Configuration.LazyLoadingEnabled = false;
                context.Configuration.ProxyCreationEnabled = false;
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContex context = new TContex())
            {
                context.Configuration.AutoDetectChangesEnabled = true;
                context.Configuration.LazyLoadingEnabled = true;
                context.Configuration.ProxyCreationEnabled = false;
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContex context = new TContex())
            {
                //context.Configuration.AutoDetectChangesEnabled = false;
                //context.Configuration.LazyLoadingEnabled = false;
                context.Configuration.ProxyCreationEnabled = false;
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
