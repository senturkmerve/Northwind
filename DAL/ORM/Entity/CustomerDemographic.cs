using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.ORM.Entity
{
    public class CustomerDemographic : BaseEntity
    {
        public int CustomerID { get; set; }
        public string CustomerDesc { get; set; }

        public virtual CustomerCustomerDemo CustomerCustomerDemos { get; set; }

    }

}
