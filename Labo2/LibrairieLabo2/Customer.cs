using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieLabo2
{
    public class Customer
    {
        public double AccountBalance { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string EMail { get; set; }
        public long Id { get; set; }
        public string name { get; set; }
        public string PostCode { get; set; }
        public string Remark { get; set; }
        public Customer()
        {

        }
        [Timestamp]
        public byte[] RowVersion { get; set; }

    }
}
