using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Models
{
    public class Reviews
    {
        public int ReviewId { get; set; }

        public int ProductId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        //Navigation Property
        public Products Product { get; set; }

    }
}