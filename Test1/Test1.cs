using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WebProjectMvc_DOMAIN;
using WebProjectMvc_DOMAIN.Data.Entities;
using Moq;

namespace Test1
{
    [TestFixture]
  public class Test1
    {
        public IRepository<Product> productrepo;
       // public IRepository<Category> categoryrepo;


        List<Product> products;
        [SetUp]
       public void initialize()
        {
            products = new List<Product>{
                new Product { ID = 0, ProductName = "table" , Stock = 22, UnitPrice = 66 , IsDisCountinued = 33,CategoryID = 1, CreateDate = DateTime.Now, IsActive = true, IsDeleted = false} };
            Mock<IRepository<Product>> mockproduc = new Mock<IRepository<Product>>();
            mockproduc.Setup(m => m.Insert(It.IsAny<Product>())).Callback((Product p) => products.Add(p));
            mockproduc.Setup(m => m.GetList()).Returns(products.AsEnumerable());
            mockproduc.Setup(m => m.Delete(It.IsAny<Product>())).Callback((Object p) => productrepo.Delete(p));


            productrepo = mockproduc.Object;

            
        }

        [Test]
        public void trial()
        {

         var a = productrepo.GetList().FirstOrDefault(x => x.ID == 0);
            
            Assert.IsTrue(products.Any(x => x.ID == 1));

        }

        public void trial2()
        {

        }

    }

}

