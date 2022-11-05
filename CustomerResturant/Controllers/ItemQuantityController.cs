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
    public class ItemQuantityController : ApiController
    {
        CustomerResturantDB Context = new CustomerResturantDB();
        ItemQuantityDAL itemQuantityDal = new ItemQuantityDAL();

        //get all item quantities in the store
        [HttpGet]
        public IHttpActionResult GetAllItems()
        {
            if (itemQuantityDal.GetAllItems() != null)
                return Ok(itemQuantityDal.GetAllItems());
            else
                return BadRequest("There're no Item Quantities in the store");
        }

        [HttpPost]
        public IHttpActionResult CreateNewItemQuantity([FromBody]ItemQuantity newItemQuentity)
        {
            if (ModelState.IsValid)
            {
                bool successfullyAddedRecord = itemQuantityDal.CreateNewItemQuantity(newItemQuentity);
                if (successfullyAddedRecord)
                {
                    return Ok("Done");
                }
            }
            return BadRequest("can't created this record");
        }

        ////add new item quantity in the store
        //[HttpPost]
        //public IHttpActionResult CreateNewItemQuantity(int id ,[FromBody]int storeId) //id= item id
        //{
        //    itemQuantityDal.AddNewItem(id, storeId);
        //    return Ok("New Item Quantity has been added");
        //}

        ////lose quantity from exist item quantity in the store
        //[HttpPut]
        //public IHttpActionResult EditExistItemQuantity(int id,int storeId,int soldQuantity)// id =item id
        //{
        //    itemQuantityDal.LoseQuantity(id, storeId, soldQuantity);
        //    return Ok("one item quantity has been updated");
        //}

        //public IHttpActionResult SubmitSale(int id, int storeId, int soldQuantity) //id=item id
        //{
        //    if (itemQuantityDal.ItemIsExist(id))
        //    {
        //        EditExistItemQuantity(id, storeId, soldQuantity);
        //    }
        //    else
        //    {
        //        CreateNewItemQuantity(id, storeId);
        //        itemQuantityDal.LoseQuantity(id, storeId, soldQuantity);
        //    }
        //    return Ok("The sale has been submitted");
        //}
    }
}
