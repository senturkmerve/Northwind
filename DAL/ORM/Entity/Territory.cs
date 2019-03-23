using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.ORM.Entity
{
    public class Territory : BaseEntity
    {
        public int TerritoryID { get; set; }
        public string TerritoryDescription { get; set; }
        public List<EmployeeTerritory> EmployeeTerritories { get; set; }
        public int RegionID { get; set; }
        public virtual Region Region { get; set; }

    }

}
