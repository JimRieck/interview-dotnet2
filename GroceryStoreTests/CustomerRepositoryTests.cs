using Moq;
using NUnit.Framework;
using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Repositories;
using System.Collections.Generic;
using GroceryStoreAPI;
using System.Linq;

namespace Tests
{
    public class CustomerRepositoryTests
    {
        List<Customers> expectedCustomers;

        [SetUp]
        public void Setup()
        {
            expectedCustomers = new List<Customers>();
            expectedCustomers.Add(new Customers { id = 1, name = "Bob" });
            expectedCustomers.Add(new Customers { id = 2, name = "Mary" });
            expectedCustomers.Add(new Customers { id = 3, name = "Joe" });
            
        }

        [Test]
        public void ShouldReturnAllCustomers()
        {
            int expectedCount = 3;
            CustomerRepository subjectUnderTest = new CustomerRepository();
            List<Customers> actualCustomers = subjectUnderTest.Get().ToList();

            Assert.AreEqual(expectedCount, actualCustomers.Count);
            
        }

        [Test]
        public void ShouldReturnCustomerWithId1()
        {
            int expectedCount = 1;
            CustomerRepository subjectUnderTest = new CustomerRepository();
            List<Customers> actualCustomers = subjectUnderTest.Get(t => t.id == 1);

            Assert.AreEqual(expectedCount, actualCustomers.Count);

        }
    }
}