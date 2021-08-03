using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class CategoryRepo
    {
        static IMSOrderEntities context;
        static CategoryRepo()
        {

            context = new IMSOrderEntities();
        }

        public static List<Category> GetCategories()
        {
             var g= context.Categories.ToList();
            return g;
        }

        public static void AddCategory(Category c)
        {
            context.Categories.Add(c);
            context.SaveChanges();
        }

        public static void EditCategory(Category c)
        {
            var old_c = context.Categories.FirstOrDefault(x => x.Id == c.Id);
            context.Entry(old_c).CurrentValues.SetValues(c);
            context.SaveChanges();
        }

        public static Category GetCategoryDetails(int id)
        {
            var data = context.Categories.FirstOrDefault(x => x.Id == id);
            return data;
        }

    }
}
