using CustomerResturant.Models;
using newWorkRes.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace newWorkRes.Controllers
{
    public class RoomController : ApiController
    {

        CustomerResturantDB Context = new CustomerResturantDB();
        RoomDAL roomDAL = new RoomDAL();


        //get available rooms
        public IHttpActionResult GetAvailableRooms()
        {
            if (roomDAL.GetAvailableRooms() != null)
            {
                return Ok(roomDAL.GetAvailableRooms());
            }
            return BadRequest("No Available Room");
        }

        //get order of the room
        [HttpGet]
        public IHttpActionResult GetRoomOrder([FromUri]int id) //id = room id
        {
            if (roomDAL.GetRoomOrder(id) != null)
                return Ok(roomDAL.GetRoomOrder(id));
            else
                return BadRequest("There's no room with this ID");
        }


        //check if the room is paused or not 
        [HttpGet]
        public IHttpActionResult IsRoomPaused([FromUri]int id)// id= room id
        {
            if (roomDAL.IfRoomISPause(id) == false)
                return Ok("This room is available");
            else
                return BadRequest("This room is not available");
        }

        //get the money on a room
        [HttpGet]
        public IHttpActionResult GetRoomMoney([FromUri]int id)//id = room id
        {
            if (roomDAL.GetMoneyOnRoom(id) != 0)
                return Ok(roomDAL.GetMoneyOnRoom(id));
            else
                return BadRequest("There's no money on this room");
        }
        

    }
}
