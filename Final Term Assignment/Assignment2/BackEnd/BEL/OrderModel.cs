using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BEL
{
   public class OrderModel
    {

        public int Id { get; set; }
        public int UserId { get; set; }
        public string OrderStatusName { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderStatusId { get; set; }
        public Nullable<System.TimeSpan> OrderTime { get; set; }
        public int Quantity { get; set; }


    }
}
