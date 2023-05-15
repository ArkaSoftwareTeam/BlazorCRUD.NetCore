using BlazorSampleCrud.DataAccessLayer.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BlazorSampleCrud.DataAccessLayer.ContextSample
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(c => c.FirstName).HasMaxLength(80).IsRequired();
            builder.Property(c => c.LastName).HasMaxLength(80).IsRequired();
            builder.Property(c => c.DateOfBirth).IsRequired().HasColumnType("date");
            builder.Property(c => c.PhoneNumber)!.IsFixedLength<string>(fixedLength: true).HasColumnType("varchar").IsUnicode(false).HasMaxLength(11).IsRequired();
            builder.Property(c => c.Email).HasMaxLength(100).IsUnicode(false).HasColumnType("varchar").IsRequired();
            builder.Property(c => c.BankAccountNumber).HasMaxLength(10).HasColumnType("varchar").IsUnicode(false).IsRequired();
        }
    }
}
