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
        //Create
        private AttractionService CreateAttractionService()
        {
            var userid = Guid.Parse(User.Identity.GetUserId());
            var noteservice = new AttractionService();
            return noteservice;
        }
        //Update
        //public IHttpActionResult Put(AttractionEdit note)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    var service = CreateAttractionService();

        //    if (!service.UpdateAttraction(note))
        //        return InternalServerError();

        //    return Ok();
        //}
    }
}
