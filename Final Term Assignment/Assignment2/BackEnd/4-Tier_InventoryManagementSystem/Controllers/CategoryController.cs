using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BEL;
using BLL;

namespace _4_Tier_InventoryManagementSystem.Controllers
{
    public class CategoryController : ApiController
    {

        [Route("api/Category/GetAll")]
        [HttpGet]
        public ICollection<CategoryModel> GetAllCategories()
        {
            return CategoryService.GetCategories();
        }

        [Route("api/Category/Add")]
        [HttpPost]
        public void Add(CategoryModel cm)
        {
            CategoryService.AddCategory(cm);
        }

        [Route("api/Category/Edit")]
        [HttpPost]
        public void Edit(CategoryModel cm)
        {
            CategoryService.EditCategory(cm);
        }

        [Route("api/Category/{id}/Details")]
        [HttpGet]
        public CategoryModel GetProductDetails(int id)
        {
            return CategoryService.GetCategoryDetails(id);
        }

    }
}
