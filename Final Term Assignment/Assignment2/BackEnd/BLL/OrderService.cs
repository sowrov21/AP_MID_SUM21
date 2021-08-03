using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;
namespace BLL
{
   public class OrderService
    {
        public static ICollection<OrderModel> GetOrders()
        {
            var Orders = OrderRepo.GetOrders();

            var data = AutoMapper.Mapper.Map<List<Order>, List<OrderModel>>(Orders);
            return data;
        }

        public static void AddOrder(OrderModel odr)
        {
            var oData = AutoMapper.Mapper.Map<OrderModel, Order>(odr);
            OrderRepo.AddOrder(oData);
        }

        public static OrderModel GetOrderDetails(int id)
        {
            var data = OrderRepo.GetOrderDetails(id);
            var ord = AutoMapper.Mapper.Map<Order, OrderModel>(data);

            return ord;
        }


        public static List<OrderModelWithProductList> GetOrderWithProductDetails()
        {
            var data = OrderRepo.GetOrders();
            var odrdDetails = AutoMapper.Mapper.Map<List<Order>, List<OrderModelWithProductList>>(data);
            return odrdDetails;

        }

        public static OrderModelWithProductList GetIndividualOrderWithProductDetails(int id)
        {
            var data = OrderRepo.GetOrderDetails(id);
            var odrdDetails = AutoMapper.Mapper.Map<Order, OrderModelWithProductList>(data);
            return odrdDetails;

        }


        public static void DeleteOrder(int id)
        {
            OrderRepo.DeleteOrder(id);
        }

    }
}
