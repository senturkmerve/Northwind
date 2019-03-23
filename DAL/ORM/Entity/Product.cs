using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.ORM.Entity
{
    public class Product : BaseEntity
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public int QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public int ReorderLevel { get; set; }
        public string Discontinued { get; set; }
        public int OrderID { get; set; }
        public virtual List  <OrderDetail> OrderDetails { get; set; }
       
    }

}
