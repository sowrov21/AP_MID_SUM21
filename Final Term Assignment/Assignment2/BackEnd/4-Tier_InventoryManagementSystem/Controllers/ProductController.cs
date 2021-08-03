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
    public class ProductController : ApiController
    {
        [Route("api/Product/GetAll")]
        [HttpGet]
        public ICollection<ProductModel> GetAllProducts()
        {
            return ProductService.GetProducts();
        }

        [Route("api/Product/Add")]
        [HttpPost]
        public void Add(ProductModel pm)
        {
            ProductService.AddProduct(pm);
        }

        [Route("api/Product/Edit")]
        [HttpPost]
        public void Edit(ProductModel pm)
        {
            ProductService.EditProduct(pm);
        }

        [Route("api/Product/{id}/Details")]
        [HttpGet]
        public ProductModel GetProductDetails(int id)
        {
            return ProductService.GetProductDetails(id);
        }

        [Route("api/Product/{id}/Delete")]
        [HttpPost]
        public void DeleteProduct(int id)
        {
            ProductService.DeleteProduct(id);
        }
    }
}
