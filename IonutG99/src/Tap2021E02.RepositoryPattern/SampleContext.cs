using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Tap2021E02.RepositoryPattern
{
    public class SampleContext:DbContext,ISampleRepository,IUnitOfWork
    {
        public SampleContext(DbContextOptions<SampleContext> contextOptions) : base(contextOptions) { }
        public void Save()
        {
            SaveChanges();
        }

        public void Delete<TEntity>(TEntity entity) where TEntity : class
        {
            Delete(entity);
        }

        public TEntity Insert<TEntity>(TEntity entity) where TEntity : class
        {
            return Insert(entity);
        }

        public IQueryable<TEntity> Query<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }

        void ISampleRepository.Update<TEntity>(TEntity entity)
        {
            Update(entity);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var registrar = this.GetService<IEntityTypeConfigurationRegistrar>();
            registrar.ApplyConfiguration(modelBuilder);
        }

        public void Commit()
        {
            throw new System.NotImplementedException();
        }
    }
}
