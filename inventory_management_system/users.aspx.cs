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
    public partial class users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                BLL_Users users = new BLL_Users();
                gridUsers.DataSource = users.GetUsers();
                gridUsers.DataBind();
            }
            
            

            

        }

        protected void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            BLL_Users users = new BLL_Users();

            UsersViewModel usersView = new UsersViewModel();

            usersView.FullName = txtFullName.Text;
            usersView.LoginName = txtLoginName.Text;
            usersView.Email = txtEmail.Text;
            usersView.Address = txtAddress.Text;
            usersView.Phone = txtPhone.Text;
            usersView.Password = txtPassword.Text;
           

            users.insertUpdateUsers(usersView);




            BLL_Users users1 = new BLL_Users();
            gridUsers.DataSource = users1.GetUsers();
            gridUsers.DataBind();

            lblconfirm.Visible = true;
            lblconfirm.Text = "insert success!!!";

             txtFullName.Text= string.Empty; 
             txtLoginName.Text= string.Empty; 
             txtEmail.Text= string.Empty; 
             txtAddress.Text= string.Empty; 
             txtPhone.Text= string.Empty; 
            txtPassword.Text= string.Empty; 

        }
    }
}