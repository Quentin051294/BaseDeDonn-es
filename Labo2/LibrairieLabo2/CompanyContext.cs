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
       public CompanyContext()
           : base(@"Data Source=vm-sql.iesn.be\stu3ig;Initial Catalog=DBIG3B3;User ID=IG3B3;Password=pwUserdb66")
        {
        }

       public CompanyContext(string connectionString)
           : base(connectionString)
       {
       }
        public DbSet<Customer> Customers { get; set; }
    }
}
