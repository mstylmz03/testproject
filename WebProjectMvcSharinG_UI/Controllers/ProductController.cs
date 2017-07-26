using ServiceLocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProjectMvc_DOMAIN;
using WebProjectMvc_DOMAIN.Data.Entities;
using WebProjectMvc_DOMAIN.IServices;
using WebProjectMvc_INFRASTRUCTURE.BaseServices;
//using WebProjectMvc_INFRASTRUCTURE.DataServices;
using WebProjectMvc_SERVICE.Services;

namespace WebProjectMvcSharinG_UI.Controllers
{
    public class ProductController : Controller
    {
        //private IRepository<Product> productrepo;
        //private IRepository<Category> categoryrepo;

        private ICategoryService categoryservice;
        private IProductService productservice;

      



        public ProductController()
        {
            //productrepo = new GenericRepository<Product>();
            //categoryrepo = new GenericRepository<Category>();

            //categoryservice = new CategoryService();
            //productservice = new ProductService();

            productservice = ServiceLocator_.GetService<IProductService>();
            categoryservice = ServiceLocator_.GetService<ICategoryService>();

        }

        //public IEnumerable<Category> GetAllCategories
        //{
        //    get { return categoryrepo.GetList(); }
        //}

        [HttpGet]
        public ActionResult Index()
        {
            
            //var model = productrepo.GetList();
            var model = productservice.GetList();

            return View(model);
        }
        [HttpGet]
        public ActionResult Add()
        {
            ViewBag.Categories = categoryservice.GetAllCategories();
            //ViewBag.Categories = GetAllCategories;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Product model)
        {
            ViewBag.Categories = categoryservice.GetAllCategories();
           //ViewBag.Categories = GetAllCategories;
            model.CreateDate = DateTime.Now;
            productservice.Insert(model);
            //productrepo.Insert(model);
            ViewBag.IsSuccess = productservice.Save() > 0 ? true : false;
            //ViewBag.IsSuccess = productrepo.Save() > 0 ? true : false;

            return View();
        }
    }
}