using ServiceLocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebProjectMvc_DOMAIN;
using WebProjectMvc_DOMAIN.Data.Entities;
using WebProjectMvc_DOMAIN.IServices;
using WebProjectMvc_INFRASTRUCTURE.BaseServices;
using WebProjectMvc_SERVICE.Services;
namespace WebProjectMvcSharinG_UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            initializeinstance();
            
            
        }

       void initializeinstance()
        {
            IProductService pservice = new ProductService();
            ICategoryService cservice = new CategoryService();

            ServiceLocator_.RegisterService(pservice);
            ServiceLocator_.RegisterService(cservice);

        }

    }
}
