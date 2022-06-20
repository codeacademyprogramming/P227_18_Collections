using System;
using System.Collections.Generic;
using System.Text;

namespace EnumTask
{
    internal class Product
    {
        public Product(string no,double price,ProductCategory category)
        {
            this.No = no;
            this.Price = price;
            this.Category = category;
        }
        public string No;
        public double Price;
        public ProductCategory Category;
    }
}
