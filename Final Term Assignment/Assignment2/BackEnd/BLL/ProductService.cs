using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL.MapperConfig;

namespace BLL
{
    public class ProductService
    {


/*        static ProductService()
        {
            AutoMapper.Mapper.Reset();
            AutoMapper.Mapper.Initialize(config => config.AddProfile<AutoMapperSettings>());
        }*/

        public static ICollection<ProductModel>  GetProducts()
        {
            var Products = ProductRepo.GetProducts();

           var data= AutoMapper.Mapper.Map<List<Product>,List<ProductModel>>(Products);

            /*List<ProductModel> data = new List<ProductModel>();
              foreach (var p in Products)
              {
                  var dm = new ProductModel()
                  {
                      Id = p.Id,
                      Name = p.Name,
                      Price = p.Price,
                      Quantity = p.Quantity,
                      Description = p.Description,
                  };
                  data.Add(dm);
              }*/
            return data;
        }

        public static void AddProduct(ProductModel pm)
        {
            var mData = AutoMapper.Mapper.Map<ProductModel, Product>(pm);
            ProductRepo.AddProduct(mData);
        }

        public static void EditProduct(ProductModel pm)
        {
            var mData = AutoMapper.Mapper.Map<ProductModel, Product>(pm);
            ProductRepo.EditProduct(mData);
        }
        public static ProductModel GetProductDetails(int id)
        {
            var data = ProductRepo.GetProductDetails(id);
            var p = AutoMapper.Mapper.Map<Product, ProductModel>(data);

            return p;
        }


        public static void DeleteProduct(int id)
        {
             ProductRepo.DeleteProduct(id);
           //AutoMapper.Mapper.Map<Product, ProductModel>(data);
        }

    }
}
