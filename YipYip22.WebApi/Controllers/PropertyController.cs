using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using YipYip22.Models;
using YipYip22.Services;

namespace YipYip22.WebApi.Controllers
{
    [Authorize]
    public class PropertyController : ApiController
    {
        public IHttpActionResult Get()
        {
            PropertyService propertyService = CreatePropertyService();
            var properties = propertyService.GetProperties();
            return Ok(properties);
        }
        public IHttpActionResult Get(int id)
        {
            PropertyService propertyService = CreatePropertyService();
            var properties = propertyService.GetPropertyById(id);
            return Ok(properties);
        }

        private PropertyService CreatePropertyService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var propertyService = new PropertyService(userId);
            return propertyService;
        }
        public IHttpActionResult Post(PropertyCreate property)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreatePropertyService();

            if (!service.CreateProperty(property))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Put(PropertyEdit property)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreatePropertyService();

            if (!service.UpdateProperty(property))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            var service = CreatePropertyService();

            if (!service.DeleteProperty(id))
                return InternalServerError();

            return Ok();
        }
    }
}
