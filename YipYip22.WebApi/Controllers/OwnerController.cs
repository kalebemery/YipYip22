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
        public class OwnerController : ApiController
        {

            public IHttpActionResult Post(OwnerCreate ownerprofile)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var service = CreateOwnerService();

                if (!service.CreateOwner(ownerprofile))
                    return InternalServerError();

                return Ok();
            }
            public IHttpActionResult Get(int id)
            {
                OwnerService ownerService = CreateOwnerService();
                var ownerprofile = ownerService.GetOwnerById(id);
                return Ok(ownerprofile);
            }
            public IHttpActionResult Put(OwnerEdit ownerprofile)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var service = CreateOwnerService();

                if (!service.UpdateOwner(ownerprofile))
                    return InternalServerError();

                return Ok();
            }
        public IHttpActionResult Delete(int id)
        {
            var service = CreateOwnerService();

            if (!service.OwnerDelete(id))
                return InternalServerError();

            return Ok();
        }
        private OwnerService CreateOwnerService()
            {
                var userId = Guid.Parse(User.Identity.GetUserId());
                var ownerService = new OwnerService(userId);
                return ownerService;
            }
        }
    
}
