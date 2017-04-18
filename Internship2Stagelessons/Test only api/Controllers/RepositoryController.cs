using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test_only_api.Models;

namespace Test_only_api.Controllers
{
    public class RepositoryController : ApiController
    {
        // GET: api/Repository
        public IEnumerable<string> Get()
        {
            return FileManager.GetAllFiles();
        }

        // GET: api/Repository/5
        public string Get(string name)
        {
            
            return FileManager.GetFileByName(name.Substring(1, name.Length - 2));
        }

        // POST: api/Repository
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Repository/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Repository/5
        public void Delete(int id)
        {
        }
    }
}
