﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Api.Models
{
    public class Author
    {

            public int Id { get; set; }
            public string Name { get; set; }
            public ICollection<Article> Articles { get; set; }
        }
    
}