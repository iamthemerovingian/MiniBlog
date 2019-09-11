using MiniBlog.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MiniBlog.Controllers
{
    [RoutePrefix("ValuesAttribute")]
    public class ValuesController : ApiController
    {
        private readonly IUserManagementService _userManagementService;

        public ValuesController(IUserManagementService userManagementService)
        {
            _userManagementService = userManagementService;
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        [Route("TestingNinject")]
        public IHttpActionResult TestingNinject()
        {
           string userToken = _userManagementService.RegisterUser();

            return Ok();
        }
    }
}
