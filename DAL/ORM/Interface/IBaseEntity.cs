using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.ORM.Interface
{
   public  interface IBaseEntity
    {
        DateTime AddDate { get; set; }
        DateTime Update { get; set; }
        int ID { get; set; }
        DateTime DeletedDate { get; set; }
        Enum.Status Status { get; set; }
    }

}
