using CustomerResturant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CustomerResturant.Controllers
{
    public class ItemsController : ApiController
    {
        CustomerResturantDB Context = new CustomerResturantDB();

        public IHttpActionResult GetItemsByCategoryId(int Id)
        {
            return Ok(Context.Item_Items.Where(ii => ii.Category_ID == Id));
        }

    }
}