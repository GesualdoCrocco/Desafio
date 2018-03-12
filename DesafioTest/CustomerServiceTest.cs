using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using Service.Context;
using System;
using System.Linq;

namespace DesafioTest.ServiceTest
{

    [TestClass]
    public class CustomerServiceTest
    {
        private DesafioContext context;
        public CustomerServiceTest()
        {
            var options = new DbContextOptionsBuilder<DesafioContext>()
                        .UseInMemoryDatabase(databaseName: "Desafio_Memory_AddTest")
                        .Options;

            context = new DesafioContext(options);

            var service = new Service.Customer.CustomerService(context);
            service.Save(new Domain.Models.Customer() { Email = "gesualdo.crocco@gmail.com", Name = "Gesualdo Crocco" });
            service.Save(new Domain.Models.Customer() { Email = "gesualdo.crocco1@gmail.com", Name = "Gesualdo Crocco 1" });
            service.Save(new Domain.Models.Customer() { Email = "gesualdo.crocco2@gmail.com", Name = "Gesualdo Crocco 2" });
            service.Save(new Domain.Models.Customer() { Email = "gesualdo.crocco3@gmail.com", Name = "Gesualdo Crocco 3" });

        }

        [TestMethod]
        public void AddTest()
        {
            var service = new Service.Customer.CustomerService(context);
            service.Save(new Domain.Models.Customer() { Email = "gesualdo.crocco4@gmail.com", Name = "Gesualdo Crocco 4" });
           
            Assert.AreEqual("gesualdo.crocco@gmail.com", context.Customers.FirstOrDefault().Email);
           

        }


        [TestMethod]
        public void GetAllTest()
        {
            var service = new Service.Customer.CustomerService(context);
            Assert.IsTrue(service.GetAll().Count > 0);
           

        }

        [TestMethod]
        public void GetByIdTest()
        {
           
            var service = new Service.Customer.CustomerService(context);
            Assert.AreEqual("Gesualdo Crocco 1", service.GetById(2).Name);
          

        }

        [TestMethod]
        public void GetByEmailTest()
        {
            var service = new Service.Customer.CustomerService(context);
            Assert.AreEqual("Gesualdo Crocco", service.GetByEmail("gesualdo.crocco@gmail.com").Name);
           

        }

       
    }
}
