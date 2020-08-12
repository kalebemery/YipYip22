//using Microsoft.AspNet.Identity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using YipYip22.Models;
//using YipYip22.Services;

//namespace YipYip22.WebApi.Controllers
//{
//    [Authorize]
//    public class BookingController : ApiController
//    {
//        private BookingService CreateBookingService()
//        {
//            var Id = Guid.Parse(User.Identity.GetUserId());
//            var bookingService = new BookingService(Id);
//            return bookingService;
//        }

//        public IHttpActionResult Get(int id)
//        {
//            BookingService bookingService = CreateBookingService();
//            var bookings = bookingService.GetBookingById(id);
//            return Ok(bookings);
//        }

//        public IHttpActionResult Post(BookingCreate booking)
//        {
//            if (!ModelState.IsValid)
//                return BadRequest(ModelState);

//            var service = CreateBookingService();

//            if (!service.CreateBooking(booking))
//                return InternalServerError();

//            return Ok();
//        }

//        public IHttpActionResult Put(BookingEdit booking)
//        {
//            if (!ModelState.IsValid)
//                return BadRequest(ModelState);

//            var service = CreateBookingService();

//            if (!service.UpdateBooking(booking))
//                return InternalServerError();

//            return Ok();

//        }

//        public IHttpActionResult Delete(int id)
//        {
//            var service = CreateBookingService();

//            if (!service.DeleteBooking(id))
//                return InternalServerError();

//            return Ok();
//        }

//    }
//}
