using Moq;
using NUnit.Framework;
using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Repositories;
using System.Collections.Generic;
using GroceryStoreAPI;
using System.Linq;

namespace Tests
{
    public class CustomerRepository
    {
        List<Customers> expectedCustomers;
        GroceryStoreAPI.Repositories.CustomerRepository subjectUnderTest;
        int expectedCount = 3;

        [SetUp]
        public void Setup()
        {
            expectedCustomers = new List<Customers>();
            expectedCustomers.Add(new Customers { id = 1, name = "Bob" });
            expectedCustomers.Add(new Customers { id = 2, name = "Mary" });
            expectedCustomers.Add(new Customers { id = 3, name = "Joe" });

            subjectUnderTest = new GroceryStoreAPI.Repositories.CustomerRepository();
        }

        [Test]
        public void ShouldReturnAllCustomers()
        {
            List<Customers> actualCustomers = subjectUnderTest.Get().ToList();

            Assert.AreEqual(expectedCount, actualCustomers.Count);
            
        }

        [Test]
        public void ShouldReturnCustomerWithId1()
        {
            expectedCount = 1;
           
            List<Customers> actualCustomers = subjectUnderTest.Get(t => t.id == 1);

            Assert.AreEqual(expectedCount, actualCustomers.Count);
            Assert.IsTrue(actualCustomers.FirstOrDefault(p => p.id == 1).id == 1);
        }

        [Test]
        public void ShouldReturnAllCustomersWhenNullConditionIsNotPassed()
        {
            List<Customers> actualCustomers = subjectUnderTest.Get();

            Assert.AreEqual(expectedCount, actualCustomers.Count);
        }
    }
}