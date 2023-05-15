using BlazorSampleCrud.DataAccessLayer.Entities.Common;


namespace BlazorSampleCrud.DataAccessLayer.Repository
{
    public interface ICustomerRepository<TEntity>:IDisposable where TEntity:BaseEntity
    {
        IQueryable<TEntity> GetEntityQuery();
        Task<TEntity?> GetEntityById(int id);
        Task AddEntity(TEntity entity);
        void UpdateEntity(TEntity entity);
        Task DeleteEntityById(int id);
        void DeleteEntity(TEntity entity);
        Task SaveChanges();

    }
}
