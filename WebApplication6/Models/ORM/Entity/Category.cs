using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication6.Models.ORM.Entity
{
    public class Category:BaseEntity
    {
        [Required(ErrorMessage ="Kategori adı giriniz!")]
        [Display(Name ="Kategori Adı")]
        public string Name { get; set; }

        [Display(Name = "Açıklama")]
        public string Description{ get; set; }
        public List<BlogPost> BlogPost { get; set; }


    }
}