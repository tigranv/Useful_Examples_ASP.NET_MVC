using Lesson1Intro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lesson1Intro.Controllers
{
    [RoutePrefix("api")]
    public class ValuesController : ApiController
    {
        [Route("values")]
        [HttpGet]
        public IHttpActionResult GetValues()
        {
            var result = new string[]
            {
                "hello world",
                "Բարև աշխարհ"
            };
            return Ok(result);
        }

        [Route("values")]
        [HttpPost]
        public IHttpActionResult SendValues(Person model)
        {
            if (model.Age < 18)
            {
                return BadRequest();
            }

            model.Age++;
            model.Name += "!";

            

            return Ok(model);
        }
    }
}
