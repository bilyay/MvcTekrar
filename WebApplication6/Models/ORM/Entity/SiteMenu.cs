using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models.ORM.Entity
{
    public class SiteMenu:BaseEntity
    {
        public string MenuName { get; set; }
        public string Descriptoin { get; set; }

    }
}