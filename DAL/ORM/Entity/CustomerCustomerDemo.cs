using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.ORM.Entity
{
    public class CustomerCustomerDemo : BaseEntity
    {
        public int CustomerID { get; set; }
        
        public int CustomerTypeID { get; set; }
        public List<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }

    }

}
