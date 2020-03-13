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
    public class ProductsRepository
    {
        List<Products> expectedProducts;
        GroceryStoreAPI.Repositories.ProductsRepository subjectUnderTest;
        int expectedCount = 3;

        [SetUp]
        public void Setup()
        {
            expectedProducts = new List<Products>();
            expectedProducts.Add(new Products { Id = 1, Description = "apple", Price = .5 });
            expectedProducts.Add(new Products { Id = 2, Description = "orange", Price = .75 });
            expectedProducts.Add(new Products { Id = 3, Description = "bananna", Price = .85 });

            subjectUnderTest = new GroceryStoreAPI.Repositories.ProductsRepository();
        }

        [Test]
        public void ShouldReturnAllCustomers()
        {
            List<Products> actualCustomers = subjectUnderTest.Get().ToList();

            Assert.AreEqual(expectedCount, actualCustomers.Count);
            
        }

        [Test]
        public void ShouldReturnCustomerWithId1()
        {
            expectedCount = 1;
           
            List<Products> actualCustomers = subjectUnderTest.Get(t => t.Id == 1);

            Assert.AreEqual(expectedCount, actualCustomers.Count);
            Assert.IsTrue(actualCustomers.FirstOrDefault(p => p.Id == 1).Id == 1);
        }

        [Test]
        public void ShouldReturnAllCustomersWhenNullConditionIsNotPassed()
        {
            List<Products> actualCustomers = subjectUnderTest.Get();

            Assert.AreEqual(expectedCount, actualCustomers.Count);
        }
    }
}