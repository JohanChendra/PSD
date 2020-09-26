using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Factory;
using TokoBeDia.Model;

namespace TokoBeDia.Repository
{
    public class ProductRepository
    {
        public static TokoBeDiaEntities db = new TokoBeDiaEntities();
        public static List<Product> GetProducts()
        {
            return (from product in db.Products select product).ToList();
        }

        public static Product GetProductid(int id)
        {
            return (from product in db.Products where product.ID == id select product).FirstOrDefault();
        }

        public static Product InsertProduct(int producttypeid, string name, int stock, int price)
        {
            Product p = ProductFactory.InsertProduct(producttypeid, name, stock, price);
            db.Products.Add(p);
            db.SaveChanges();
            return p;
        }

        public static void UpdateProduct(int id, string name, int stock, int price)
        {
            Product p = GetProductid(id);
            p.Name = name;
            p.Stock = stock;
            p.Price = price;
            db.SaveChanges();
        }

        public static void DeleteProduct(int id)
        {
            Product p = GetProductid(id);
            if (p != null)
            {
                db.Products.Remove(p);
            }
            db.SaveChanges();
        }
    }
}