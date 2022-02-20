using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inventory_management_system.model
{
    public class UsersViewModel
    {

        public int ID { get; set; }
        public string FullName { get; set; }
        public string LoginName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }




    }
}





//ID int identity(1,1) primary key,
//FullName varchar(100),
//LoginName varchar(20),
//Email varchar(50),
//Phone varchar(15),
//[Address] varchar(100),
//[Password] varchar(100)