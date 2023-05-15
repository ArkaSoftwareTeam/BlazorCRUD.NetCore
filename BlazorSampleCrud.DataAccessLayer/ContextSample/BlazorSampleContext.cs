using BlazorSampleCrud.DataAccessLayer.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorSampleCrud.DataAccessLayer.ContextSample
{
    public class BlazorSampleContext : DbContext
    {
        #region ContextConstractor
        public BlazorSampleContext(DbContextOptions<BlazorSampleContext> options) : base(options)
        {

        }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var casecade = modelBuilder.Model.GetEntityTypes()
                .SelectMany(i => i.GetForeignKeys())
                .Where(f => f.IsOwnership && f.DeleteBehavior == DeleteBehavior.Cascade);
            foreach (var foreignKey in casecade)
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }


            modelBuilder.ApplyConfiguration(new CustomerConfig());
        }

        public DbSet<Customer> Customers { get; set; }

    }
}
