using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models.ORM.Entity
{
    public class AdminUser:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }

    }
}