using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models.ORM.Entity
{
    public class BaseEntity
    {
        public int ID { get; set; }
        private DateTime _addDate { get; set; }
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = DateTime.Now; }

        }
        private bool _isDeleted { get; set; }
        public bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = false; }
        }
        public DateTime? DeleteDate { get; set; }
    }
}