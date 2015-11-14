using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieLabo2
{
   public class CompanyContext : DbContext
    {
        public CompanyContext(String ConnectionString) : base(ConnectionString)
        {
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
