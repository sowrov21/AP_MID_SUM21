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
    public class OrderController : ApiController
    {
        //Get All Orders
        [Route("api/Order/GetAll")]
        [HttpGet]
        public ICollection<OrderModel> GetAllOrders()
        {
            return OrderService.GetOrders();
        }

        //Add Orders
        [Route("api/Order/Add")]
        [HttpPost]
        public void Add(OrderModel odr)
        {
            OrderService.AddOrder(odr);
        }

        //Get Individual Orders
        [Route("api/Order/{id}/Details")]
        [HttpGet]
        public OrderModel GetOrderDetails(int id)
        {
            return OrderService.GetOrderDetails(id);
        }

        //Get all Orders with their All Products

        [Route("api/Order/GetAll/WithProductDetails")]
        public List<OrderModelWithProductList> GetOrderWithProductDetails()
        {
            return OrderService.GetOrderWithProductDetails();
        }


        //Get indivisual Orders with their Products

        [Route("api/Order/Get/{id}/WithProductDetails")]
        public OrderModelWithProductList GetIndividualOrderWithProductDetails(int id)
        {
            return OrderService.GetIndividualOrderWithProductDetails(id);
        }

        //Delete Orders 
        [Route("api/Order/{id}/Delete")]
        [HttpPost]
        public void DeleteOrder(int id)
        {
            OrderService.DeleteOrder(id);
        }
    }
}
