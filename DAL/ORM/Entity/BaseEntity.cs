using Northwind.DAL.ORM.Enum;
using Northwind.DAL.ORM.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.ORM.Entity
{
    public class BaseEntity : IBaseEntity

    {
       

        public int ID { get; set; }

        private DateTime _addDate = DateTime.Now;
        public DateTime AddDate { get { return _addDate; } set { _addDate = value; } }


        private DateTime _updateDate = DateTime.Now;

        public DateTime UpdateDate { get { return _updateDate; } set { _update = value; } }

        private DateTime _update { get { return _update; } set { _update = value; } }


        public DateTime DeleteDate = DateTime.Now;
        private DateTime _deleteDate { get { return _deleteDate; } set { _deleteDate = value; } }

        public Status _status = Status.Active;
        public Status Status { get { return _status; } set { _status = value; } }
        private Role _role;
        public Role role { get { return _role; } set { _role = value; } }

        public DateTime Update
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DateTime DeletedDate
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}



