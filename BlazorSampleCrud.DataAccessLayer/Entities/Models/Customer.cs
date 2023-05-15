using BlazorSampleCrud.DataAccessLayer.Entities.Common;

namespace BlazorSampleCrud.DataAccessLayer.Entities.Models
{
    public class Customer : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? BankAccountNumber { get; set; }


    }
}
