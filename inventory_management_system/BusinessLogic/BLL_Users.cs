using inventory_management_system.model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace inventory_management_system.BusinessLogic
{
     public class BLL_Users: BLL_connections
    {
        
            
            
            
            public  List<UsersViewModel> GetUsers()
        {
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                List<UsersViewModel> users = new List<UsersViewModel>();
                conn.Open();
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from Users";
                    cmd.CommandType = System.Data.CommandType.Text;
                    

                    SqlDataReader rdr = cmd.ExecuteReader();
                    if(rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            UsersViewModel user = new UsersViewModel();
                            user.ID = Convert.ToInt32(rdr["ID"]);
                            user.FullName = rdr["FullName"].ToString();
                            user.LoginName = rdr["LoginName"].ToString();
                            user.Email = rdr["Email"].ToString();
                            user.Phone = rdr["Phone"].ToString();
                            user.Address = rdr["Address"].ToString(); ;
                            user.Password = rdr["Password"].ToString();

                            users.Add(user);

                        }
                    }
                    return users;
                }
            }
        }



        public int insertUpdateUsers(UsersViewModel user)
        {
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
               
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "spAddUpdateUsers";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter[] param = new SqlParameter[]

                    {
                        new SqlParameter("@ID", user.ID ),
                        new SqlParameter("@FullName", user.FullName),
                        new SqlParameter("@LoginName",user.LoginName ),
                        new SqlParameter("@Email", user.Email),
                        new SqlParameter("@Phone", user.Phone),
                        new SqlParameter("@Address", user.Address),
                        new SqlParameter("@Password", user.Password),
                    };
                    cmd.Parameters.AddRange(param);

                    int res = cmd.ExecuteNonQuery();
                    return res;
                }
            }
        }
    }
}