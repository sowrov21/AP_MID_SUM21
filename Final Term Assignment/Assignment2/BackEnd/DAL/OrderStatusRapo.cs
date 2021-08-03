using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class OrderStatusRapo
    {
        static IMSOrderEntities context;
        static OrderStatusRapo()
        {

            context = new IMSOrderEntities();
        }

        public static List<OrderStatus> GetOrderStatuses()
        {
            return context.OrderStatuses.ToList();
        }

        public static void AddOrderStatus(OrderStatus os)
        {
            context.OrderStatuses.Add(os);
            context.SaveChanges();
        }

        public static OrderStatus GetOrderStatusDetails(int id)
        {
            var data = context.OrderStatuses.FirstOrDefault(x => x.Id == id);
            return data;
        }
    }
}
