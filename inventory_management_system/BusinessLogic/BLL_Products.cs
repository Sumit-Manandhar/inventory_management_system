using inventory_management_system.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace inventory_management_system.BusinessLogic
{
    public class BLL_Products : BLL_connections
    {
        public List<ProductViewModel> getProducts()
        {
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                List<ProductViewModel> products = new List<ProductViewModel>();
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from Products";
                    cmd.CommandType = System.Data.CommandType.Text;

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ProductViewModel product = new ProductViewModel();
                            product.ID = Convert.ToInt32(reader["ID"]);

                            product.Name = reader["Name"].ToString();
                            product.Code = reader["Code"].ToString();
                            product.CategoryID = Convert.ToInt32(reader["PurchasePrice"]);
                            product.PurchasePrice = Convert.ToDecimal(reader["SalesPrice"]);
                            product.SalesPrice = Convert.ToDecimal(reader["SalesPrice"]  );  //reader["Code"].ToString();
                            product.Description = reader["Code"].ToString();
                            //product.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                            //product.CreatedUserID = Convert.ToInt32(reader["CategoryID"]);
                            //product.ModifiedDate = Convert.ToDateTime(reader["PurchasePrice"]);
                            //product.ModifiedUserID = Convert.ToInt32(reader["ModifiedUserID"]);



                            products.Add(product);
                        }

                    }

                    return products;


                }

            }
        }

        public int insertUpdateProducts(ProductViewModel product)
        {
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {

                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "spAddUpdateProducts";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter[] param = new SqlParameter[]

                    {
                        new SqlParameter("@ID", product.ID ),
                        new SqlParameter("@Name", product.Name),
                        new SqlParameter("@CategoryID",product.CategoryID ),
                        new SqlParameter("@PurchasePrice",product.PurchasePrice ),
                        new SqlParameter("@Description",product.Description ),
                        new SqlParameter("@SalesPrice",product.SalesPrice ),
                        new SqlParameter("@Code",product.Code ),

                    };
                    cmd.Parameters.AddRange(param);

                    int res = cmd.ExecuteNonQuery();
                    return res;
                }
            }
        }

        //public static bool Insert(ProductViewModel model)
        //{
        //    insertUpdateProducts.Add(model);
        //    return true;
        //}
    }
}