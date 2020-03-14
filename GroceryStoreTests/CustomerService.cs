using GroceryStoreAPI;
using GroceryStoreAPI.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using GroceryStoreAPI.Services;

namespace GroceryStoreTests
{
    public class CustomerServiceTests
    {
        List<Customers> expectedCustomers;
        Mock<IRepository<Customers>> mockCustomerRepo = new Mock<IRepository<Customers>>();

        CustomerService subjectUnderTest;
        int expectedCount = 1;

        [SetUp]
        public void Setup()
        {
            expectedCustomers = new List<Customers>();
            expectedCustomers.Add(new Customers { id = 1, name = "Bob" });
            expectedCustomers.Add(new Customers { id = 2, name = "Mary" });
            expectedCustomers.Add(new Customers { id = 3, name = "Joe" });

           subjectUnderTest = new CustomerService(mockCustomerRepo.Object);
           mockCustomerRepo.Setup(x => x.Get(null)).Returns(expectedCustomers);
            
        }

        [Test]
        public void ShouldReturnAllCustomers()
        {
            mockCustomerRepo.Setup(x => x.Get(null));
            List<Customers> actualCustomers = subjectUnderTest.GetAll();
            mockCustomerRepo.VerifyAll();   
        }
    }
}
