using inventory_management_system.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace inventory_management_system.BusinessLogic
{
    public class BLL_Category :BLL_connections
    {
        public List<CategoryViewModel> getCategory()
        {
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                List<CategoryViewModel> categories = new List<CategoryViewModel>();
                conn.Open();
                using (SqlCommand cmd= new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from category";
                    cmd.CommandType = System.Data.CommandType.Text;

                    SqlDataReader reader = cmd.ExecuteReader();
                    if(reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CategoryViewModel category = new CategoryViewModel();
                            category.ID = Convert.ToInt32(reader["ID"]);
                        
                            category.Name = reader["Name"].ToString();
                            category.Code = reader["Code"].ToString();


                            categories.Add(category);
                        }
                        
                    }

                    return categories;


                }

            }
        }

        public int insertUpdatecategory(CategoryViewModel category)
        {
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {

                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "spAddUpdateCategory";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter[] param = new SqlParameter[]

                    {
                        new SqlParameter("@ID", category.ID ),
                        new SqlParameter("@Name", category.Name),
                        new SqlParameter("@Code",category.Code ),
                        
                    };
                    cmd.Parameters.AddRange(param);

                    int res = cmd.ExecuteNonQuery();
                    return res;
                }
            }
        }


    }
}

//cmd.Connection = conn;
//cmd.CommandText = "select * from Users";
//cmd.CommandType = System.Data.CommandType.Text;


//SqlDataReader rdr = cmd.ExecuteReader();
//if (rdr.HasRows)
//{
//    while (rdr.Read())
//    {
//        UsersViewModel user = new UsersViewModel();
//        user.ID = Convert.ToInt32(rdr["ID"]);
//        user.FullName = rdr["FullName"].ToString();
//        user.LoginName = rdr["LoginName"].ToString();
//        user.Email = rdr["Email"].ToString();
//        user.Phone = rdr["Phone"].ToString();
//        user.Address = rdr["Address"].ToString(); ;
//        user.Password = rdr["Password"].ToString();

//        users.Add(user);

//    }
//}
//return users;