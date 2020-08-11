using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YipYip22.Data;
using YipYip22.Models;

namespace YipYip22.Services
{
    public class BookingService
    {
        private readonly Guid _Id;
        public BookingService(Guid Id)
        {
            _Id = Id;
        }


        public bool CreateBooking(BookingCreate model)
        {
            var booking = new Booking()
            {
                BookingId = model.BookingId,
                ProfileId = model.ProfileId,
                PropertyId = model.PropertyId,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                NumOfWeekDay = model.NumOfWeekDay,
                NumOfWeekend = model.NumOfWeekend,
                TotalPrice = model.TotalPrice


            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Bookings.Add(booking);
                return ctx.SaveChanges() == 1;
            }
        }

        public BookingDetail GetBookingById(int renterid)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Bookings
                        .Single(e => e.ProfileId == renterid);
                return
                    new BookingDetail
                    {
                        BookingId = entity.BookingId,
                        ProfileId = entity.ProfileId,
                        PropertyId = entity.PropertyId,
                        StartDate = entity.StartDate,
                        EndDate = entity.EndDate,
                        NumOfWeekDay = entity.NumOfWeekDay,
                        NumOfWeekend = entity.NumOfWeekend,
                        TotalPrice = entity.TotalPrice
                    };
            }
        }

        public bool UpdateBooking(BookingEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Bookings
                        .Single(e => e.BookingId == model.BookingId && e.ProfileId == model.ProfileId);
                entity.StartDate = model.StartDate;
                entity.EndDate = model.EndDate;
                entity.NumOfWeekend = model.NumOfWeekend;
                entity.NumOfWeekDay = model.NumOfWeekDay;
                entity.TotalPrice = model.TotalPrice;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteBooking(int bookingId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Bookings
                    .Single(e => e.BookingId == bookingId);

                ctx.Bookings.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }

    }
}
