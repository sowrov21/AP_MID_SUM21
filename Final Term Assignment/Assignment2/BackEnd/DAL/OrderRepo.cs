using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderRepo
    {
        static IMSOrderEntities context;
        static OrderRepo()
        {

            context = new IMSOrderEntities();
        }

        public static List<Order> GetOrders()
        {
            return context.Orders.ToList();
        }

        public static void AddOrder(Order odr)
        {
            context.Orders.Add(odr);
            context.SaveChanges();
        }

        public static Order GetOrderDetails(int id)
        {
            var data = context.Orders.FirstOrDefault(x => x.Id == id);
            return data;
        }

        public static Order GetIndividualOrderWithProductDetails(int id)
        {
            var data = context.Orders.FirstOrDefault(x => x.Id == id);
            return data;
        }

        public static void DeleteOrder(int id)
        {
            var data = context.Orders.FirstOrDefault(x => x.Id == id);
            context.Orders.Remove(data);
            context.SaveChanges();
        }

    }
}
