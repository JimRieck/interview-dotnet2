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
         int expectedCount = 1;

        [SetUp]
        public void Setup()
        {
            expectedOrders = this.GetOrders();
           

            subjectUnderTest = new GroceryStoreAPI.Repositories.OrdersRepository();
        }

        [Test]
        public void ShouldReturnAllOrders()
        {
            List<Orders> orders = subjectUnderTest.GetAll();

            Assert.AreEqual(expectedCount, orders.Count);
        }

        [Test]
        public void ShouldReturnOrdersWithId1()
        {
            expectedCount = 1;
            
            Orders order = subjectUnderTest.GetById(1);

            Assert.IsNotNull(order);
            
        }

       
    }
}