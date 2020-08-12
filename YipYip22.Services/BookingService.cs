//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using YipYip22.Data;
//using YipYip22.Models;

//namespace YipYip22.Services
//{
//    public class BookingService
//    {
//        private readonly Guid _Id;
//        public BookingService(Guid Id)
//        {
//            _Id = Id;
//        }
//        public bool CreateBooking(BookingCreate model)
//        {
//            var firstDay = new DateTime();
//            DateTime.TryParse((model.StartDate).ToString(), out firstDay);
//            var lastDay = new DateTime();
//            DateTime.TryParse((model.EndDate).ToString(), out lastDay);
//            Property priceOfProperty = new Property();
//            List<Booking> book = new List<Booking>();
//            Booking rentersBooking = new Booking();
//            using (var ctx = new ApplicationDbContext())
//            {
//                var query =
//                    ctx
//                    .Bookings.Where(b => (firstDay >= b.StartDate && firstDay < b.EndDate || (firstDay < b.StartDate && lastDay >= b.StartDate))).ToList();
//                int propertyId = model.PropertyId;
//                bool unavailableRoom = book.Any(b => b.PropertyId == propertyId);
//                if (unavailableRoom)
//                {
//                    return false;
//                }
//                else
//                    rentersBooking.BookingId = model.BookingId;
//                rentersBooking.ProfileId = model.ProfileId;
//                rentersBooking.PropertyId = model.PropertyId;
//                rentersBooking.StartDate = model.StartDate;
//                rentersBooking.EndDate = model.EndDate;
//                rentersBooking.TotalPrice = (priceOfProperty.WeekdayRate * rentersBooking.NumOfWeekDay) + (priceOfProperty.WeekendRate * rentersBooking.NumOfWeekend);
//                priceOfProperty = ctx.Properties.FirstOrDefault(p => p.PropertyId == model.PropertyId);
//                ctx.Bookings.Add(rentersBooking);
//                return ctx.SaveChanges() == 1;
//            }
//        }
//        public BookingDetail GetBookingById(int renterid)
//        {
//            using (var ctx = new ApplicationDbContext())
//            {
//                var entity =
//                    ctx
//                        .Bookings
//                        .Single(e => e.ProfileId == renterid);
//                return
//                    new BookingDetail
//                    {
//                        BookingId = entity.BookingId,
//                        ProfileId = entity.ProfileId,
//                        PropertyId = entity.PropertyId,
//                        StartDate = entity.StartDate,
//                        EndDate = entity.EndDate,
//                        TotalPrice = entity.TotalPrice
//                    };
//            }
//        }
//    }
//}
