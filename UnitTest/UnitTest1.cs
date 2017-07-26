using System;
using NUnit.Framework;
using WebProjectMvc_DOMAIN;
using WebProjectMvc_DOMAIN.Data.Entities;
using System.Collections.Generic;
using Moq;
using System.Linq;

namespace UnitTest
{
    [TestFixture]
    public class UnitTest1
    {
        public IRepository<Product> productrepo;


        List<Product> products;

        [SetUp]
        public void initialize()
        {
            products = new List<Product>()
           {
               new Product {ID = 1, ProductName = "Telephone" , Stock =69 , UnitPrice = 66 , IsDisCountinued = 33,CategoryID = 1, CreateDate = DateTime.Now, IsActive = true, IsDeleted = false  },
               new Product {ID = 3, ProductName = "Television" , Stock =78 , UnitPrice = 26 , IsDisCountinued = 33,CategoryID = 1, CreateDate = DateTime.Now, IsActive = true, IsDeleted = false  }
           };

            Mock<IRepository<Product>> mockproduct = new Mock<IRepository<Product>>();

            mockproduct.Setup(m => m.Insert(It.IsAny<Product>())).Callback((Product p) => products.Add(p));

            productrepo = mockproduct.Object;
        }



        [Test]
        public void TestMethod1()
        {
          
            var a = productrepo.GetList(p => p.ID == 3);

            Assert.IsTrue(products.Any(x => x.ID == 3));


        }


    }
}
