using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IVO.Mvc.SpionShop.Web.Models
{
    public class Product
    {
        public string Naam { get; set; }
        public Categorie Categorie { get; set; }
    }
}