using MiniBlog.Business.Services;
using MiniBlog.Filters;
using MiniBlog.GeneralInfrastructure.Models.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MiniBlog.Controllers
{
    [MiniBlogAuthorize]
    [RoutePrefix("CardManagement")]
    public class CardMagamentController : ApiController
    {
        private readonly ICardManagementService _cardManagementService;

        public CardMagamentController(ICardManagementService cardManagementService)
        {
            _cardManagementService = cardManagementService;
        }

        [HttpPost]
        public IHttpActionResult CreateCard(CreateCardRequestModel request)
        {
            CreateCardResponseModel response = _cardManagementService.CreateCard(request, )
        }

        [HttpGet]
        public IHttpActionResult GetCard(id)
    }
}
