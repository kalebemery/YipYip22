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
    public class ProfileController : ApiController
    {
        public IHttpActionResult Get()
        {
            ProfileService profileService = CreateProfileService();
            var people = profileService.ProfileListItems();
            return Ok(people);
        }
        public IHttpActionResult Post(ProfileCreate profile)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateProfileService();

            if (!service.CreateProfile(profile))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Get(int id)
        {
            ProfileService profileService = CreateProfileService();
            var profile = profileService.GetProfileById(id);
            return Ok(profile);
        }
        public IHttpActionResult Put(ProfileEdit profile)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateProfileService();

            if (!service.UpdateProfile(profile))
                return InternalServerError();

            return Ok();
        }
        private ProfileService CreateProfileService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var profileService = new ProfileService(userId);
            return profileService;
        }
    }
}
