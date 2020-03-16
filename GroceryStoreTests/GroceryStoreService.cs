using GroceryStoreAPI;
using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Models;
using GroceryStoreAPI.Services;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tests;

namespace GroceryStoreTests
{
    public class GroceryStoreService : BaseTest
    {
        private Mock<IGroceryStoreRepository> mockGroceryStoreRepository;
        private Mock<ICustomerRepository> mockCustomerRepository;
        private Mock<IOrdersRepository> mockOrdersRepository;
        private Mock<IProductsRepository> mockProductsRepository;
        private List<Customers> expectedCustomers;
        private List<Orders> expectedOrders;
        private List<Products> expectedProducts;
        private GroceryStoreInfo expectedStoreInfo;

        private GroceryStoreAPI.Services.GroceryStoreService subjectUnderTest;

        [SetUp]
        public void Setup()
        {
            mockGroceryStoreRepository = new Mock<IGroceryStoreRepository>();
            mockCustomerRepository = new Mock<ICustomerRepository>();
            mockOrdersRepository = new Mock<IOrdersRepository>();
            mockProductsRepository = new Mock<IProductsRepository>();


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
