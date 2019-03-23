﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.ORM.Entity
{
    public class Order : BaseEntity
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }

        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public string ShipVia { get; set; }
        public string Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public virtual Shipper Shipper { get; set; }

       
    }

}
