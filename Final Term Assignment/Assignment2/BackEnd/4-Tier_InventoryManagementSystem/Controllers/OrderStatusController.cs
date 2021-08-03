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
    public class OrderStatusController : ApiController
    {
        [Route("api/OrderStatus/GetAll")]
        [HttpGet]
        public ICollection<OrderStatusModel> GetAllOrderStatuses()
        {
            return OrderStatusService.GetOrderStatuses();
        }

        [Route("api/OrderStatus/Add")]
        [HttpPost]
        public void Add(OrderStatusModel os)
        {
            OrderStatusService.AddOrderStatus(os);
        }

        [Route("api/OrderStatus/{id}/Details")]
        [HttpGet]
        public OrderStatusModel GetOrderStatusDetails(int id)
        {
            return OrderStatusService.GetOrderStatusDetails(id);
        }
    }
}
