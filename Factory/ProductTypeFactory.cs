using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;

namespace TokoBeDia.Factory
{
    public class ProductTypeFactory
    {
        public static ProductType InsertProductType(string name, string description)
        {
            ProductType pt = new ProductType()
            {
                Name = name,
                Description = description,
            };
            return pt;
        }
    }
}