using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;

namespace TokoBeDia.Factory
{
    public class ProductFactory
    {
        public static Product InsertProduct(int producttypeid,string name, int stock, int price)
        {
            Product p = new Product()
            {
                ProductTypeID = producttypeid,
                Name = name,
                Price = price,
                Stock = stock,
            };
            return p;
        }
    }
}