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

            subjectUnderTest = new GroceryStoreAPI.Services.GroceryStoreService(mockCustomerRepository.Object, mockOrdersRepository.Object, mockProductsRepository.Object);
        }

        [Test]
        public void ShouldPopulateGroceryStoreInfoObject()
        {
            mockCustomerRepository.Setup(p => p.GetAll()).Returns(expectedCustomers);
            mockOrdersRepository.Setup(p => p.GetAll()).Returns(expectedOrders);
            mockProductsRepository.Setup(p => p.GetAll()).Returns(expectedProducts);

            subjectUnderTest.Build();

            mockCustomerRepository.VerifyAll();
            mockOrdersRepository.VerifyAll();
            mockProductsRepository.VerifyAll();
        }
    }
}
