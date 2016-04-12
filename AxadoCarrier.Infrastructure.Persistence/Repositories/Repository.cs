using AxadoCarrier.Infrastructure.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxadoCarrier.Infrastructure.Persistence.Repositories
{
    public abstract class Repository<T>
        where T : BaseEntity
    {
        private DbContext DataContext { get; set; }
        protected DbSet<T> DataSet { get; private set; }

        protected Repository(DbContext dbContext)
        {
            this.DataContext = dbContext;
            this.DataSet = this.DataContext.Set<T>();
        }

        public virtual void Add(T entity)
        {
            this.DataSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            var currentPersistenceEntity = this.DataSet.Find(entity.Id);

            if (currentPersistenceEntity == null)
                throw new Exception(string.Format("The entity with ID {0} does not already exist.", entity.Id));

            this.DataContext.Entry(currentPersistenceEntity).CurrentValues.SetValues(entity);
        }

        public virtual T Get(Guid id)
        {
            return this.DataSet.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return this.DataSet.ToList();
        }

        public virtual void Delete(Guid id)
        {
            var entity = this.DataSet.Find(id);

            this.DataContext.Entry(entity).State = EntityState.Deleted;

        }
    }
}
