using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Product
    {
        public int quantity { set; get; }
        public string image { set; get; }
        public int price { set; get; }
        public string name {set; get;}
    }
}