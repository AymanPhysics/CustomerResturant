using CustomerResturant.DAL;
using CustomerResturant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CustomerResturant.Controllers
{
    public class OrderController : ApiController
    {
        CustomerResturantDB Context = new CustomerResturantDB();
        OrderDAL orderDAL = new OrderDAL();

        //localhost:44379/api/Order/GetAllOrders
        //get all orders
        public IHttpActionResult GetAllOrders()
        {
            if (orderDAL.GetAllOrders() != null)
                return Ok(orderDAL.GetAllOrders());
            else
                return BadRequest("There are no orders");
        }

        //localhost:44379/api/Order/GetExistedOrder/id
        // get specific order by order id
        [HttpGet]
        public IHttpActionResult GetExistedOrder(int id) // id= order id
        {
            if (orderDAL.searchOrder(id) != null)
                return Ok(orderDAL.searchOrder(id));
            else
                return BadRequest("No order with id : " + id);
        }

        //localhost:44379/api/Order/GetCustomerOrders/id
        // get orders for specific customer by customer id(supplier id)
        [HttpGet]
        public IHttpActionResult GetCustomerOrders(int id) // id = suuplier id(customer id)
        {
            if (orderDAL.GetCustomerOrders(id) != null)
                return Ok(orderDAL.GetCustomerOrders(id));
            else
                return BadRequest("No orders for this customer");
        }


        //localhost:44379/api/Order/GetRoomOrders/id
        // get orders for specific room by room number
        [HttpGet]
        public IHttpActionResult GetRoomOrders(int id) // id = room number
        {
            if (orderDAL.GetOrdersForSpecificRoom(id) != null)
                return Ok(orderDAL.GetOrdersForSpecificRoom(id));
            else
                return BadRequest("No orders for this room");
        }


        //localhost:44379/api/Order/GetTableOrders/id
        // get orders for specific room by table number
        [HttpGet]
        public IHttpActionResult GetTableOrders(int id) // id = table number
        {
            if (orderDAL.GetOrdersForSpecificTable(id) != null)
                return Ok(orderDAL.GetOrdersForSpecificTable(id));
            else
                return BadRequest("No orders for this Table");
        }


        //localhost:44379/api/Order/GetOrdersInSpecificPeriod?startDate=2020-06-03 00:00:00.000&endDate=2020-06-18 00:00:00.000
        //get all orders for a specific rang of date :
        // d1 start date
        //d2 end date
        [HttpGet]
        public IHttpActionResult GetOrdersInSpecificPeriod([FromUri]DateTime startDate, [FromUri]DateTime endDate)
        {
            if (orderDAL.GetOrdersBetweenTwoDates(startDate, endDate) != null)
            { return Ok(orderDAL.GetOrdersBetweenTwoDates(startDate, endDate)); }
            else
                return BadRequest("No Orders btween " + startDate + " and " + endDate);
        }

        //localhost:44379/api/Order/CreateOrder
        //create new order
        [HttpPost]
        public IHttpActionResult CreateOrder([FromBody] Order_Orders order)
        {
            if (!orderDAL.IsOrderExist(order.ID))
            {
                orderDAL.CreateNewOrder(order);
                return Ok("one order added successfully");
            }
            else
                return BadRequest("there's already existed order with this id");
        }


        //localhost:44379/api/Order/DeleteOrder/id
        //delete existed order 
        [HttpDelete]
        public IHttpActionResult DeleteOrder(int id) //id = order id
        {
            if (orderDAL.IsOrderExist(id))
            {
                orderDAL.DeleteOrder(id);
                return Ok("One order deleted successfully");
            }
            else
                return BadRequest("There is no order with id : "+id);
        }

        ///////////////////////// Order Details /////////////

        //localhost:44379/api/Order/GetAllOrderDetails
        //get all records for order details model :
        [HttpGet]
        public IHttpActionResult GetOrderDetailsRecords()
        {
            return Ok(orderDAL.GellAllOrderDetails());
        }

        //localhost:44379/api/Order/GetOrderDetails/id
        //get order details for specific order
        [HttpGet]
        public IHttpActionResult GetOrderDetails(int id) //id = order id
        {
            if (orderDAL.IsOrderExist(id))
            {
                return Ok(orderDAL.GetOrderDetails(id));
            }
            else
                return BadRequest("This Order not existed");
        }

        //localhost:44379/api/Order/GetOrderDetailsFromSpecificStore/id
        //get order details from specific store 
        [HttpGet]
        public IHttpActionResult GetOrderDetailsFromSpecificStore(int id) //id=store id
        {
            if (orderDAL.GetStoreOrders(id) != null || orderDAL.GetStoreOrders(id).Count() != 0)
            { return Ok(orderDAL.GetStoreOrders(id)); }
            else
                return BadRequest("No Order Details in this store");
        }


        //localhost:44379/api/Order/GetOrderDetailsFromSpecificSItem/id
        //get all order details for specific item
        [HttpGet]
        public IHttpActionResult GetOrderDetailsFromSpecificSItem(int id) //id = item id
        {
            if (orderDAL.GetOrderDetailsForItem(id) != null || !orderDAL.GetOrderDetailsForItem(id).Any())
                return Ok(orderDAL.GetOrderDetailsForItem(id));
            else
                return BadRequest("No order details for this item");
        }

        //localhost:44379/api/Order/CreateOrderDetails
        //create new order details record
        [HttpPost]
        public IHttpActionResult CreateOrderDetails([FromBody] Order_OrdersDetails orderDetails)
        {
            if (!orderDAL.IsOrderDetailsExist(orderDetails.Purchese_ID))
            {
                orderDAL.CreateNewOrderDetails(orderDetails);
                return Ok("One order details added successfully");
            }
            else
                return BadRequest("This order details is already existed");
        }


        //localhost:44379/api/Order/DeleteOrderDetails/id
        //delete existed order 
        [HttpDelete]
        public IHttpActionResult DeleteOrderDetails(int id) //id = order id
        {
            if (orderDAL.IsOrderDetailsExist(id))
            {
                orderDAL.DeleteOrderDetailsRecord(id);
                return Ok("One order deleted successfully");
            }
            else
                return BadRequest("There is no order with id : " + id);
        }
    }
}
