using CustomerResturant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newWorkRes.DAL
{
    public class RoomDAL
    {
        CustomerResturantDB Context = new CustomerResturantDB();

        //get available rooms
        public IEnumerable<Restaurant_Room> GetAvailableRooms() => Context.Restaurant_Room.Where(room => room.ISPause == false);

        //get orderId of the room by roomId
        public int? GetOrderIdOfRoom(int _roomId) => Context.Restaurant_Room.Where(room => room.ID == _roomId).Select(room => room.OrderID).FirstOrDefault();


        //get order of the room by room id
        public Order_Orders GetRoomOrder(int _roomId)
        {
            int? OrderId = GetOrderIdOfRoom(_roomId);
            return Context.Order_Orders.Where(order => order.ID == OrderId).FirstOrDefault();
        }


        //get money on the room by roomID
        public decimal? GetMoneyOnRoom(int _roomId) => Context.Restaurant_Room.Where(room => room.ID == _roomId).Select(room => room.Money).FirstOrDefault();


        //check if the room is paused by room ID
        public bool IfRoomISPause(int _roomId)
        {
            Restaurant_Room RoomToChecked = Context.Restaurant_Room.Where(room => room.ID == _roomId).FirstOrDefault();
            if (RoomToChecked.ISPause == false)
                return false;
            else
                return true;
        }
    }
}