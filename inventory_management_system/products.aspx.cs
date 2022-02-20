using inventory_management_system.BusinessLogic;
using inventory_management_system.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace inventory_management_system
{
    public partial class products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(!this.IsPostBack)
            //{
            //    BLL_Products products = new BLL_Products();
            //    GridProducts.DataSource = products.getProducts();
            //    GridProducts.DataBind();
            //}
        }

        [WebMethod]
        [HttpPost]
        [System.Web.Script.Services.ScriptMethod(UseHttpGet = false, ResponseFormat = System.Web.Script.Services.ResponseFormat.Json)]
        public static object Insert(ProductViewModel product)
        {
            BLL_Products Products = new BLL_Products();

            return Products.insertUpdateProducts(product);
        }


    }
}