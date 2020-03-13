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
            List<Orders> actualOrders = subjectUnderTest.Get().ToList();

            Assert.AreEqual(expectedCount, actualOrders.Count);
            
        }

        [Test]
        public void ShouldReturnOrdersWithId1()
        {
            expectedCount = 1;
           
            List<Orders> actualOrders = subjectUnderTest.Get(t => t.Id == 1);

            Assert.AreEqual(expectedCount, actualOrders.Count);
            Assert.IsTrue(actualOrders.FirstOrDefault(p => p.Id == 1).Id == 1);
        }

        [Test]
        public void ShouldReturnAllOrdersWhenNullConditionIsNotPassed()
        {
            List<Orders> actualOrders = subjectUnderTest.Get();

            Assert.AreEqual(expectedCount, actualOrders.Count);
        }
    }
}