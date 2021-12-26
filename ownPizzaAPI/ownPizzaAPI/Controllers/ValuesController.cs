using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Web.Http;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using ownPizzaAPI.Models;
using Swashbuckle.Swagger.Annotations;

namespace ownPizzaAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values

        [HttpGet]

        public IHttpActionResult GetProduct()
        {

            StreamReader r = new StreamReader(@"C:\ownPizza\mydata.json");
            string jsonString = r.ReadToEnd();
            var result =  JsonConvert.DeserializeObject<OwnPizza>(jsonString);
            return Ok(result);
        }

        
    }
}
