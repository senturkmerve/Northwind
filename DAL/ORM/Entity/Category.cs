using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.ORM.Entity
{
    public class Category : BaseEntity
    {
        public int CategoryID { get; set; }

        public List  <Product> Products { get; set; }
        public String CategoryName { get; set; }
        public string CategoryDescription { get; set; }
       
    }

}
