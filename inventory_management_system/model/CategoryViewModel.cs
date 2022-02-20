using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inventory_management_system.model
{
    public class CategoryViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }


        //        ID int identity(1,1) primary key,
        //[Name] varchar(100),
        //Code varchar(50)
    }
}