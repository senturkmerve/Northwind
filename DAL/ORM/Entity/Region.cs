using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.ORM.Entity
{
    public class Region : BaseEntity
    {
        public int RegionID { get; set; }

        public string RegionDescription { get; set; }
        public List<Territory> Territories { get; set; }
    }

}
