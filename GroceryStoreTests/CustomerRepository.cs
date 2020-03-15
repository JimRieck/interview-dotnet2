using Moq;
using NUnit.Framework;
using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Repositories;
using System.Collections.Generic;
using GroceryStoreAPI;
using System.Linq;
using GroceryStoreAPI.Models;

namespace Tests
{
    public class CustomerRepository
    {
        List<Customers> expectedCustomers;
        GroceryStoreAPI.Repositories.CustomerRepository<Customers> subjectUnderTest;
        int expectedCount = 3;

        [SetUp]
        public void Setup()
        {
            expectedCustomers = new List<Customers>();
            expectedCustomers.Add(new Customers { id = 1, name = "Bob" });
            expectedCustomers.Add(new Customers { id = 2, name = "Mary" });
            expectedCustomers.Add(new Customers { id = 3, name = "Joe" });

            subjectUnderTest = new GroceryStoreAPI.Repositories.CustomerRepository<Customers>();
        }

        [Test]
        public void ShouldReturnAllCustomers()
        {
          
            List<Customers> customers = subjectUnderTest.GetAll();

            Assert.AreEqual(expectedCount, customers.Count);
            
        }

        [Test]
        public void ShouldReturnCustomerWithId1()
        {
            expectedCount = 1;
            
            Customers customer = subjectUnderTest.GetById(1);

            Assert.IsNotNull(customer);
            
        }
    }
}