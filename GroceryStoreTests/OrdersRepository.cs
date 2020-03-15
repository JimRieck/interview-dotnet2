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
    public class OrdersRepository : BaseTest
    {
         List<Orders> expectedOrders;
         GroceryStoreAPI.Repositories.OrdersRepository subjectUnderTest;
        Mock<IItemsRepository> mockItemsRepository;
         int expectedCount = 1;

        [SetUp]
        public void Setup()
        {
            expectedOrders = this.GetOrders();

            mockItemsRepository = new Mock<IItemsRepository>();
            mockItemsRepository.Setup(p => p.GetAll(It.IsAny<string>())).Returns(this.GetItems());

            subjectUnderTest = new GroceryStoreAPI.Repositories.OrdersRepository(mockItemsRepository.Object);
        }

        [Test]
        public void ShouldReturnAllOrders()
        {
            List<Orders> orders = subjectUnderTest.GetAll();

            Assert.AreEqual(expectedCount, orders.Count);
            mockItemsRepository.VerifyAll();
        }

        [Test]
        public void ShouldReturnOrdersWithId1()
        {
            expectedCount = 1;
            
            Orders order = subjectUnderTest.GetById(1);

            Assert.IsNotNull(order);
            mockItemsRepository.VerifyAll();
        }

       
    }
}