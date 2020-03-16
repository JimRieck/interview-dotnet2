using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using GroceryStoreAPI.Models;

namespace Tests
{
    public class ProductsRepository : BaseTest
    {
         List<Products> expectedProducts;
         GroceryStoreAPI.Repositories.ProductsRepository subjectUnderTest;
         int expectedCount = 3;

        [SetUp]
        public void Setup()
        {
            expectedProducts = this.GetProducts();

            subjectUnderTest = new GroceryStoreAPI.Repositories.ProductsRepository();
        }

        [Test]
        public void ShouldReturnAllProducts()
        {
            List<Products> actualProducts = subjectUnderTest.GetAll().ToList();

            Assert.AreEqual(expectedCount, actualProducts.Count);
        }

        [Test]
        public void ShouldReturnProductsWithId1()
        {
            expectedCount = 1;
           
            Products actualProducts = subjectUnderTest.GetById(1);

            Assert.IsTrue(actualProducts.id == 1);
        }
    }
}