using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class ProductRepo
    {
        static IMSEntities context;
        static ProductRepo()
        {

            context = new IMSEntities();
        }

        public static List<Product> GetProducts()
        {
            return context.Products.ToList();
        }

        public static void AddProduct(Product p)
        {
            context.Products.Add(p);
            context.SaveChanges();
        }

        public static Product GetProductDetails(int id)
        {
            var data = context.Products.FirstOrDefault(x => x.Id == id);
            return data;
        }

        public static void DeleteProduct(int id)
        {
            var data = context.Products.FirstOrDefault(x => x.Id == id);
            context.Products.Remove(data);
            context.SaveChanges();
        }

    }
}
