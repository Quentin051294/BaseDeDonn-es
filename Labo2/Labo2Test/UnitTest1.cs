using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibrairieLabo2;
using System.Data.Entity;
using System.Linq;

namespace Labo2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsertionFonctionnelle()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<CompanyContext>());
            Customer quentin = new Customer();
            quentin.City = "Moustier";
            CompanyContext context = new CompanyContext(@"Data Source=vm-sql.iesn.be\stu3ig;Initial Catalog=DBIG3B3;User ID=IG3B3;Password=pwUserdbp");
            context.Customers.Add(quentin);
            context.SaveChanges();
            TestMethod2();
        }

        public void TestMethod2()
        {
            CompanyContext context = new CompanyContext(@"Data Source=vm-sql.iesn.be\stu3ig;Initial Catalog=DBIG3B3;User ID=IG3B3;Password=pwUserdbp");
            Assert.IsTrue(context.Customers.Count() >= 1);
        }
    }
}
