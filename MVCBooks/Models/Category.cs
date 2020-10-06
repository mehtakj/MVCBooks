﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBooks.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
    }
}
