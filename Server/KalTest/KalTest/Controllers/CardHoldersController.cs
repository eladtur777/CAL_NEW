using CalTest.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace CalTest.Controllers
{
    public class CardHoldersController : ApiController
    {
        List<string> restrictedApp = new List<string>();


        [System.Web.Http.HttpGet]
        public IHttpActionResult GetClients()
        {
            //first check if origin exist
            if (!Request.Headers.Contains("Origin"))
            {
                //second check what the source type application of the request
                if (Request.Headers.UserAgent.ToString().ToLower().Contains("postman"))
                {
                    //return bad request
                    return BadRequest("404 - PAGE NOT FOUND");
                }
                if (!Request.Headers.UserAgent.ToString().ToLower().Contains("chrome"))
                {
                    //return bad request
                    return BadRequest("404 - PAGE NOT FOUND");
                }
            }


            if (Request.Headers.Contains("Origin"))
            {
                var values = Request.Headers.GetValues("Origin");

            }


            if (MyData.CardHolder.Count > 0)
			{
				var json = new JavaScriptSerializer().Serialize(MyData.CardHolder);
				return Ok(json);
			}
			else
			{
				IList<CardHolder> clients = new List<CardHolder>
			{
				new CardHolder
				{
				   id = 1,
				   FirstName = "רותי",
				   LastName = "משען",
				   age = 43,
				   AccountNumber = "452185",
				   Misgeret = "30,000",
				   Stage = "1"
				},
				new CardHolder
				{
				   id = 2,
				   FirstName = "רותי",
				   LastName = "משען",
				   age = 43,
				   AccountNumber = "452185",
				   Misgeret = "30,000",
				   Stage = "1"
				},
				new CardHolder
				{
					id = 3,
				   FirstName = "רותי",
				   LastName = "משען",
				   age = 43,
				   AccountNumber = "452185",
				   Misgeret = "30,000",
				   Stage = "1"
				},
				new CardHolder
				{
				   id = 4,
				   FirstName = "רותי",
				   LastName = "משען",
				   age = 43,
				   AccountNumber = "452185",
				   Misgeret = "30,000",
				   Stage = "1"
				}

			};

				var json = new JavaScriptSerializer().Serialize(clients);
				return Ok(json);
			}
        }

    }
}