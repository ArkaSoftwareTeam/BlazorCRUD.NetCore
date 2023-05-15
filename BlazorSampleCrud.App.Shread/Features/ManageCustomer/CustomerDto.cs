using System.Globalization;
using System.Text.Json.Serialization;
using Microsoft.VisualBasic;

namespace BlazorSampleCrud.App.Shread.Features.ManageCustomer
{
    public class CustomerDto
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }



        [JsonPropertyName("firstName")]
        public string? FirstName { get; set; }


        [JsonPropertyName("lastName")]
        public string? LastName { get; set; }


        [JsonPropertyName("dateOfBirth")] 
        public DateTime DateOfBirth { get; set; } = new DateTime(2022, 05, 01);


        [JsonPropertyName("phoneNumber")]
        public string? PhoneNumber { get; set; }


        [JsonPropertyName("email")]
        public string? Email { get; set; }


        [JsonPropertyName("bankAccountNumber")]
        public string? BankAccountNumber { get; set; }


        [JsonPropertyName("isDelete")]
        public bool IsDelete { get; set; }



    }
}
