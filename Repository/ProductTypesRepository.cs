using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Factory;
using TokoBeDia.Model;


namespace TokoBeDia.Repository
{
    public class ProductTypesRepository
    {
        public static TokoBeDiaEntities db = new TokoBeDiaEntities();
        public static ProductType GetProductTypeid(int id)
        {
            return (from pt in db.ProductTypes where pt.ID == id select pt).FirstOrDefault();
        }

        public static ProductType InsertProductType(string name, string description)
        {
            ProductType pt = ProductTypeFactory.InsertProductType(name, description);
            db.ProductTypes.Add(pt);
            db.SaveChanges();
            return pt;
        }

        public static List<ProductType> GetProductTypes()
        {
            return (from pt in db.ProductTypes select pt).ToList();
        }

        public static void UpdateProductType(int id, string name, string description)
        {
            ProductType pt = GetProductTypeid(id);
            pt.Name = name;
            pt.Description = description;
            db.SaveChanges();
        }

        public static void DeleteProductType(int id)
        {
            ProductType pt = GetProductTypeid(id);
            if (pt!=null)
            {
                db.ProductTypes.Remove(pt);
            }
            db.SaveChanges();
        }
    }
}