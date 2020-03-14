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
    public class OrdersRepository
    {
        List<Orders> expectedOrders;
        GroceryStoreAPI.Repositories.OrdersRepository subjectUnderTest;
        int expectedCount = 1;

        [SetUp]
        public void Setup()
        {
            expectedOrders = new List<Orders>();
            expectedOrders.Add(new Orders { Id = 1, CustomerId =  1});

            subjectUnderTest = new GroceryStoreAPI.Repositories.OrdersRepository();
        }

        [Test]
        public void ShouldReturnAllOrders()
        {
            GroceryStoreInfo info = new GroceryStoreInfo();
            info = subjectUnderTest.GetAll();

            Assert.AreEqual(expectedCount, info.Orders.Count);
            
        }

        [Test]
        public void ShouldReturnOrdersWithId1()
        {
            expectedCount = 1;
            GroceryStoreInfo info = new GroceryStoreInfo();
            info = subjectUnderTest.GetById(1);

            Assert.AreEqual(expectedCount, info.Orders.Count);
            
        }

       
    }
}