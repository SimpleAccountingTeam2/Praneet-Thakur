using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Models
{
    public class ProductDetailsDto
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public int Price { get; set; }

        public List<Reviews> Reviews { get; set; }
    }
}