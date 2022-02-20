using inventory_management_system.BusinessLogic;
using inventory_management_system.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace inventory_management_system.controller
{
    public class ProductController : ApiController
    {
        // GET api/<controller>
        [HttpGet]
        public object test()
        {
            return true;
        }
        [Route("api/product/insert")]
        [AcceptVerbs("POST")]
        [HttpPost]
        public object Insert(ProductViewModel products)
        {
            BLL_Products product = new BLL_Products();

            return product.insertUpdateProducts(products);
        }
    }
}