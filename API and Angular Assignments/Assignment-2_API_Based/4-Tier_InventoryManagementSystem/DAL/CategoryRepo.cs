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
            return context.Categories.ToList();
        }

        public static void AddCategory(Category c)
        {
            context.Categories.Add(c);
            context.SaveChanges();
        }

        public static Category GetCategoryDetails(int id)
        {
            var data = context.Categories.FirstOrDefault(x => x.Id == id);
            return data;
        }

    }
}
