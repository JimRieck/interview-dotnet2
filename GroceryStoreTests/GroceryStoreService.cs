using GroceryStoreAPI;
using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Models;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using Tests;

namespace GroceryStoreTests
{
    public class GroceryStoreService : BaseTest
    {
        private Mock<IGroceryStoreRepository> mockGroceryStoreRepository;
        private Mock<IDataRepository<Customers>> mockCustomerRepository;
        private Mock<IDataRepository<Orders>> mockOrdersRepository;
        private Mock<IDataRepository<Products>> mockProductsRepository;
        private List<Customers> expectedCustomers;
        private List<Orders> expectedOrders;
        private List<Products> expectedProducts;
        private GroceryStoreInfo expectedStoreInfo;

        private GroceryStoreAPI.Services.GroceryStoreService subjectUnderTest;

        [SetUp]
        public void Setup()
        {
            mockGroceryStoreRepository = new Mock<IGroceryStoreRepository>();
            mockCustomerRepository = new Mock<IDataRepository<Customers>>();
            mockOrdersRepository = new Mock<IDataRepository<Orders>>();
            mockProductsRepository = new Mock<IDataRepository<Products>>();


            expectedCustomers = this.GetCustomers();
            expectedOrders = this.GetOrders();
            expectedProducts = this.GetProducts();
            expectedStoreInfo = this.GetInfo();

            subjectUnderTest = new GroceryStoreAPI.Services.GroceryStoreService(mockGroceryStoreRepository.Object);
        }

        [Test]
        public void ShouldPopulateGroceryStoreInfoObject()
        {
            mockGroceryStoreRepository.Setup(p => p.Build()).Returns(expectedStoreInfo);
            subjectUnderTest.Build();

            mockGroceryStoreRepository.VerifyAll();
        }
    }
}
