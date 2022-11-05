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
    public class TableController : ApiController
    {
        CustomerResturantDB Context = new CustomerResturantDB();
        TableDAL tableDAL = new TableDAL();


        public IHttpActionResult GetAvailableTables()
        {
            if (tableDAL.GetAvailableTables() != null)
            {
                return Ok(tableDAL.GetAvailableTables());
            }

            return BadRequest("Not available tables");
        }


        //get order of the table
        [HttpGet]
        public IHttpActionResult GetTableOrder(int id)// id= table id
        {
            if (tableDAL.GetTableOrder(id) != null)
                return Ok(tableDAL.GetTableOrder(id));
            else
                return BadRequest("No order for this table");
        }


        //check if the table is paused or not 
        [HttpGet]
        public IHttpActionResult IsTablePaused(int id)//id = table id
        {
            if (tableDAL.IfTableISPause(id) != false)
                return Ok("This table is available");
            else
                return BadRequest("This table is not available");
        }

        //get the money on a room
        [HttpGet]
        public IHttpActionResult GetTableMoney(int id) // id = table id
        {
            if (tableDAL.GetMoneyOnTable(id) != 0)
                return Ok(tableDAL.GetMoneyOnTable(id));
            else
                return BadRequest("No money on this table");
        }
    }
}
