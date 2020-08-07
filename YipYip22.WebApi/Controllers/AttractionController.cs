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
    public class AttractionController : ApiController
    {   //CREATE
        public IHttpActionResult Post(AttractionCreate note)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateAttractionService();

            if (!service.CreateAttraction(note))
                return InternalServerError();

            return Ok();
        }
        //Create method used to access service layer for each CRUD operation in controller
        private AttractionService CreateAttractionService()
        {
            var userid = Guid.Parse(User.Identity.GetUserId());
            var noteservice = new AttractionService(userid);
            return noteservice;
        }
        //READ
        public IHttpActionResult Get()
        {
            AttractionService attractionService = CreateAttractionService();
            var attractions = attractionService.GetAllAttractions();
            return Ok(attractions);
        }
        //UPDATE
        public IHttpActionResult Put(AttractionEdit attraction)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateAttractionService();

            if (!service.UpdateAttraction(attraction))
                return InternalServerError();

            return Ok();
        }
        //DELETE
        public IHttpActionResult Delete(int id)
        {
            var service = CreateAttractionService();

            if (!service.DeleteAttraction(id))
                return InternalServerError();

            return Ok();
        }
    }
}
