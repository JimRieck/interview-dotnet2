using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using GroceryStoreAPI.Models;

namespace Tests
{
    public class ItemsRepository
    {
        List<Items> expectedOrders;
        GroceryStoreAPI.Repositories.ItemsRepository subjectUnderTest;
        int expectedCount = 1;

        [SetUp]
        public void Setup()
        {
            expectedOrders = new List<Items>();
            expectedOrders.Add(new Items { ProductId = 1, Quantity =  2});
            expectedOrders.Add(new Items { ProductId = 2, Quantity = 3 });
            subjectUnderTest = new GroceryStoreAPI.Repositories.ItemsRepository();
        }

        [Test]
        public void ShouldReturnAllItems()
        {
            List<Items> actualItems = subjectUnderTest.Get().ToList();
            

            Assert.AreEqual(expectedCount, actualItems.Count);
            
        }

        [Test]
        public void ShouldReturnItemsWithId1()
        {
            expectedCount = 1;
           
            List<Items> actualItems = subjectUnderTest.Get(t => t.ProductId == 1);

            Assert.AreEqual(expectedCount, actualItems.Count);
            Assert.IsTrue(actualItems.FirstOrDefault(p => p.ProductId == 1).ProductId == 1);
        }

        [Test]
        public void ShouldReturnAllItemsWhenNullConditionIsNotPassed()
        {
            List<Items> actualOrders = subjectUnderTest.Get();

            Assert.AreEqual(expectedCount, actualOrders.Count);
        }
    }
}