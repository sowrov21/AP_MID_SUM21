using AutoMapper;
using DAL;
using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MapperConfig
{
    public class AutoMapperSettings:Profile
    {
        public AutoMapperSettings()
        {
            CreateMap<ProductModel, Product>().ForMember(e => e.Category,pm => pm.Ignore());
            CreateMap<CategoryModel, Category>().ForMember(e => e.Products, pm => pm.Ignore());
        }
    }
}
