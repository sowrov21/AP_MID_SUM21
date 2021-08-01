using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
   public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public int ProductStatusId { get; set; }
        public string OrderStatusName { get; set; }
    }
}
