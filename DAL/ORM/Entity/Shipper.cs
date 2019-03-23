using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.ORM.Entity
{
    public class Shipper : BaseEntity
    {
        public int ShipperID { get; set; }
        public String CompanyName { get; set; }
        public string  Phone { get; set; }

        public int ShipVia { get; set; }

        public virtual List  <Order> Orders { get; set; }


    }

}
