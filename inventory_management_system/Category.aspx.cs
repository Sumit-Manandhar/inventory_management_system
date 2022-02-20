using inventory_management_system.BusinessLogic;
using inventory_management_system.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace inventory_management_system
{
    public partial class Category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                BLL_Category category = new BLL_Category();
                gridCategory.DataSource = category.getCategory();
                gridCategory.DataBind();

                //BLL_Users users = new BLL_Users();
                //gridUsers.DataSource = users.GetUsers();
                //gridUsers.DataBind();
            }

        }

        protected void gridCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            BLL_Category categories = new BLL_Category();

            CategoryViewModel categoryView = new CategoryViewModel();

            categoryView.Name = txtName.Text;
            categoryView.Code = txtCode.Text;



            categories.insertUpdatecategory(categoryView);




            BLL_Category users1 = new BLL_Category();
            gridCategory.DataSource = users1.getCategory();
            gridCategory.DataBind();

           

            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
           
        }
    }
}