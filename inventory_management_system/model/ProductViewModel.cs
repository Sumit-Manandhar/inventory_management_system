using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inventory_management_system.model
{
    public class ProductViewModel
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public  string Code { get; set; }
        public int CategoryID { get; set; }
        public decimal PurchasePrice { get; set; }
        public string Description { get; set; }
        public decimal SalesPrice { get; set; }
        public int CreatedUserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedUserID { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
//ID int identity(1,1) primary key,
//[Name] varchar(100),
//Code varchar(50),
//CategoryID int foreign key references Category(ID),
//PurchasePrice decimal(20, 2),
//[Description] varchar(100),
//SalesPrice decimal(20, 2),
//CreatedUserID int foreign key references Users(ID),
//CreatedDate datetime,
//ModifiedUserID int foreign key references Users(ID),
//ModifiedDate datetime