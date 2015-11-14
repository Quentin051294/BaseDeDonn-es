using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibrairieLabo2;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.Infrastructure;

namespace Labo2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DbUpdateConcurrencyException))]
        public void DetecteLesEditionsConcurrentes()
        {
            var contextedeJohn = new CompanyContext();
            var clientDeJohn = contextedeJohn.Customers.First();

            var contextedeSarah = new CompanyContext();
            var clientDeSarah = contextedeSarah.Customers.First();

            clientDeJohn.AccountBalance += 1000;
            contextedeJohn.SaveChanges();

            clientDeSarah.AccountBalance += 2000;
            contextedeSarah.SaveChanges();


        }
        [TestMethod]
        public void InsertionFonctionnelle()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<CompanyContext>());
            Customer quentin = new Customer();
            quentin.City = "Moustier";
            CompanyContext context = new CompanyContext(@"Data Source=vm-sql.iesn.be\stu3ig;Initial Catalog=DBIG3B3;User ID=IG3B3;Password=pwUserdb66");
            context.Customers.Add(quentin);
            context.SaveChanges();
            TestMethod2();
        }

        public void TestMethod2()
        {
            CompanyContext context = new CompanyContext(@"Data Source=vm-sql.iesn.be\stu3ig;Initial Catalog=DBIG3B3;User ID=IG3B3;Password=pwUserdb66");
            Assert.IsTrue(context.Customers.Count() >= 1);
        }
    }
}
