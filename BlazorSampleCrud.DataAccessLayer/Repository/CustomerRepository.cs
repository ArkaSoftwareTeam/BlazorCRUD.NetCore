using BlazorSampleCrud.DataAccessLayer.ContextSample;
using BlazorSampleCrud.DataAccessLayer.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace BlazorSampleCrud.DataAccessLayer.Repository
{
    public class CustomerRepository<TEntity>:ICustomerRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly BlazorSampleContext _ctx;
        private DbSet<TEntity> _dbset;

        #region Constractor
        public CustomerRepository(BlazorSampleContext context)
        {
            _ctx = context;
            _dbset = this._ctx.Set<TEntity>();

        }

        #endregion

        #region CustomerCrudMethods
        public IQueryable<TEntity> GetEntityQuery()
        {
            return _dbset.AsQueryable().Where(i => i.IsDelete == false);
        }
        public async Task<TEntity?> GetEntityById(int id)
        {
            TEntity? SingleCustomer = await _dbset.SingleOrDefaultAsync(e => e.Id == id && e.IsDelete == false);
            return SingleCustomer;
        }
        public async Task AddEntity(TEntity entity)
        {
            await _dbset.AddAsync(entity);
            await SaveChanges();
        }
        public void UpdateEntity(TEntity entity)
        {
             _dbset.Update(entity);

        }
        public async Task DeleteEntityById(int id)
        {
            var entity = await GetEntityById(id);
            if (entity != null) DeleteEntity(entity);
            
        }
        public void DeleteEntity(TEntity entity)
        {
            entity.IsDelete = true;
            UpdateEntity(entity);
            
        }
        public async Task SaveChanges()
        {
            await _ctx.SaveChangesAsync();
        }
        public void Dispose()
        {
            _ctx?.Dispose();
        }
        #endregion


    }
}
