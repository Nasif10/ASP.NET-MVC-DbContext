using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DbContext_Product.Models
{
    public enum ProductCategory
    {
        Drinks, Snacks, Chocolate, Baking, Cleaning_Supplies
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public ProductCategory? ProductCategory { get; set; }
        public string ProductPrice { get; set; }
    }
}