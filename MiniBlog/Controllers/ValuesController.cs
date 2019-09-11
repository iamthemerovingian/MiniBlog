using MiniBlog.Business.Services;
using MiniBlog.GeneralInfrastructure.Models.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MiniBlog.Controllers
{
    [RoutePrefix("UserManagement")]
    public class UserManagementController : ApiController
    {
        private readonly IUserManagementService _userManagementService;

        public UserManagementController(IUserManagementService userManagementService)
        {
            _userManagementService = userManagementService;
        }
        //// GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}

        [Route("RegisterNewUser")]
        public IHttpActionResult RegisterUser(RegisterUserRequestModel registerUserRequestModel)
        {
           string userToken = _userManagementService.RegisterUser(registerUserRequestModel);

            return Ok(userToken);
        }
    }
}
