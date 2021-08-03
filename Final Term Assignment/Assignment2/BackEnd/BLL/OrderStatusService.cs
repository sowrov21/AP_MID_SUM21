using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class OrderStatusService
    {

        public static ICollection<OrderStatusModel> GetOrderStatuses()
        {
            var OrderStatuses = OrderStatusRapo.GetOrderStatuses();

            var data = AutoMapper.Mapper.Map<List<OrderStatus>, List<OrderStatusModel>>(OrderStatuses);

            return data;
        }

        public static void AddOrderStatus(OrderStatusModel os)
        {
            var osData = AutoMapper.Mapper.Map<OrderStatusModel, OrderStatus>(os);
            OrderStatusRapo.AddOrderStatus(osData);
        }
        public static OrderStatusModel GetOrderStatusDetails(int id)
        {
            var data = OrderStatusRapo.GetOrderStatusDetails(id);
            var os = AutoMapper.Mapper.Map<OrderStatus, OrderStatusModel>(data);
            return os;
        }
    }
}
