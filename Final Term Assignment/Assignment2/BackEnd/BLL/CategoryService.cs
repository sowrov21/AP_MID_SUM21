using BEL;
using BLL.MapperConfig;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class CategoryService
    {
/*        static CategoryService()
        {
            AutoMapper.Mapper.Reset();
            AutoMapper.Mapper.Initialize(config => config.AddProfile<AutoMapperSettings>());
        }*/

        public static ICollection<CategoryModel> GetCategories()
        {
            var Categories = CategoryRepo.GetCategories();

            var data = AutoMapper.Mapper.Map<List<Category>, List<CategoryModel>>(Categories);

            return data;
        }

        public static void AddCategory(CategoryModel cm)
        {
            var mData = AutoMapper.Mapper.Map<CategoryModel, Category>(cm);
            CategoryRepo.AddCategory(mData);
        }

        public static void EditCategory(CategoryModel cm)
        {
            var mData = AutoMapper.Mapper.Map<CategoryModel, Category>(cm);
            CategoryRepo.EditCategory(mData);
        }
        public static CategoryModel GetCategoryDetails(int id)
        {
            var data = CategoryRepo.GetCategoryDetails(id);
            var c = AutoMapper.Mapper.Map<Category, CategoryModel>(data);
            return c;
        }
    }
}
