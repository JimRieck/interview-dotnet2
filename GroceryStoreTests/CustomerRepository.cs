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
    public class CustomerRepository : BaseTest
    {
         List<Customers> expectedCustomers;
         GroceryStoreAPI.Repositories.CustomerRepository subjectUnderTest;
         int expectedCount = 3;

        [SetUp]
        public void Setup()
        {
            expectedCustomers = this.GetCustomers();

            subjectUnderTest = new GroceryStoreAPI.Repositories.CustomerRepository();
        }

        [Test]
        public void ShouldReturnAllCustomers()
        {
          
            List<Customers> customers = subjectUnderTest.GetAll();

            Assert.AreEqual(expectedCount, customers.Count);
            
        }
    }
}