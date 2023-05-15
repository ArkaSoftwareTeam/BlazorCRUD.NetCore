using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSampleCrud.DataAccessLayer.Entities.Common
{
    public class Status
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }

        public bool Succuss { get; set; }


    }
}
