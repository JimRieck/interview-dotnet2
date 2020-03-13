using NUnit.Framework;
using System.Collections.Generic;
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
        public void ShouldReturnAllProducts()
        {
            List<Products> actualProducts = subjectUnderTest.Get().ToList();

            Assert.AreEqual(expectedCount, actualProducts.Count);
            
        }

        [Test]
        public void ShouldReturnProductsWithId1()
        {
            expectedCount = 1;
           
            List<Products> actualProducts = subjectUnderTest.Get(t => t.Id == 1);

            Assert.AreEqual(expectedCount, actualProducts.Count);
            Assert.IsTrue(actualProducts.FirstOrDefault(p => p.Id == 1).Id == 1);
        }

        [Test]
        public void ShouldReturnAllProductsWhenNullConditionIsNotPassed()
        {
            List<Products> actualProducts = subjectUnderTest.Get();

            Assert.AreEqual(expectedCount, actualProducts.Count);
        }
    }
}