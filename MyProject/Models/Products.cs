﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyProject.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Product Name Required.")]
        [DisplayName("Product Name")]

        public string ProductName { get; set; }

        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Category Name Required.")]
        public string CategoryName { get; set; }

        public string Remarks { get; set; }

        internal static int Count()
        {
            throw new NotImplementedException();
        }
    }

    public class EFCodeFirstEntieis : DbContext
    {
        public DbSet<Products> products { get; set; }
    }
}