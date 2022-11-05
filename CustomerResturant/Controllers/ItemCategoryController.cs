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
    public class ItemCategoryController : ApiController
    {
        ItemGroupsDAL ItemGroupsDAL = new ItemGroupsDAL();

        [HttpGet]
        public IHttpActionResult GetAllItemCategories()
        {
            return Ok(ItemGroupsDAL.GetAllItemsCategoriess());
        }

        [HttpGet]
        public IHttpActionResult GetSpecificItemCategory(int id) // id = categoryID
        {
            if (ItemGroupsDAL.SearchSpecificItemCategory(id) != null)
                return Ok(ItemGroupsDAL.SearchSpecificItemCategory(id));
            return NotFound();
        } 

        [HttpGet]
        public IHttpActionResult GetItemsByCategoryID(int id) // id = item Category ID
        {
            if (ItemGroupsDAL.SearchSpecificItemCategory(id) != null && ItemGroupsDAL.GetItemsByCategoryID(id)!=null && ItemGroupsDAL.GetItemsByCategoryID(id).Count() > 0)
            {
                return Ok(ItemGroupsDAL.GetItemsByCategoryID(id));
            }
            return BadRequest("No Items For this category type");
        }

        [HttpPost]
        public IHttpActionResult CreateNewItemCategory(Item_Groups newItemCategory)
        {
            if (ModelState.IsValid)
            {
                if (ItemGroupsDAL.CreateNewItemCategory(newItemCategory))
                    return Ok("Categoty is created successfully");
            }
            return BadRequest("Can't create this category");
        }

        [HttpPut]
        public IHttpActionResult EditItemCategory(int id , Item_Groups updatedItemCaregory) // id = categoryID
        {
            if (ModelState.IsValid && ItemGroupsDAL.SearchSpecificItemCategory(id) != null)
            {
                if (ItemGroupsDAL.EditExistedItemCategory(id, updatedItemCaregory))
                    return Ok("Category is edited successfully");
            }
            return BadRequest("Can't edit this category");
        }

        [HttpDelete]
        public IHttpActionResult DeleteItemCategory(int id) // id = categoryID
        {
            if (ItemGroupsDAL.SearchSpecificItemCategory(id) != null)
            {
                if (ItemGroupsDAL.DeleteExistedItemCategory(id))
                    return Ok("Category is deleted successfully");
            }
            return BadRequest("Can't delete this category");
        }

    }
}
