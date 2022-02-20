using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace inventory_management_system.BusinessLogic
{
    public class BLL_connections
    {

         public string connectionStr => ConfigurationManager.ConnectionStrings["inventory_management_002"].ConnectionString;

    }
}