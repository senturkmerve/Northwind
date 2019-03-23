using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.ORM.Entity
{
    public class Supplier : BaseEntity
    {
        public int SupplierID { get; set; }
        public String CompanyName { get; set; }
        public String ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public int PostelCode { get; set; }
        public string Country { get; set; }
        public int Phone { get; set; }
        public int Fax { get; set; }
        public string HomePage { get; set; }
        public virtual List<Product> Products { get; set; }
    }

}
