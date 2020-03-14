using GroceryStoreAPI;
using GroceryStoreAPI.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using GroceryStoreAPI.Services;
using GroceryStoreAPI.Models;

namespace GroceryStoreTests
{
    public class OrdersServiceTests
    {
        List<Orders> expectedOrders;
        Mock<IRepository<Orders>> mockOrdersRepo = new Mock<IRepository<Orders>>();

        OrdersService subjectUnderTest;
        int expectedCount = 1;

        [SetUp]
        public void Setup()
        {
           
            expectedOrders = new List<Orders>();
            expectedOrders.Add(new Orders { Id = 1, CustomerId = 1 });

            subjectUnderTest = new OrdersService(mockOrdersRepo.Object);
            mockOrdersRepo.Setup(x => x.Get(null)).Returns(expectedOrders);
            
        }

        [Test]
        public void ShouldReturnAllCustomers()
        {
            mockOrdersRepo.Setup(x => x.Get(null));
            List<Orders> actualCustomers = subjectUnderTest.GetAll();
            mockOrdersRepo.VerifyAll();   
        }
    }
}
