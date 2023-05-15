using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSampleCrud.DataAccessLayer.Entities.Models
{
    public class CustomerView
    {
        public List<Customer>? Customers { get; set; }= new List<Customer>();
    }
}
