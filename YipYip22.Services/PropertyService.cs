using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using YipYip22.Data;
using YipYip22.Models;

namespace YipYip22.Services
{
    public class PropertyService
    {
        private readonly Guid _userId;
        public PropertyService(Guid userId)
        {
            _userId = userId;
        }

        //CREATE PROPERTY
        public bool CreateProperty(PropertyCreate model)
        {
           
            var property = new Property()
            {
                OwnerId = model.OwnerId,
                Title = model.Title,
                Address = model.Address,
                NumOfBeds = model.NumOfBeds,
                Desc = model.Desc,
                WeekdayRate = model.WeekDayRate,
                WeekendRate = model.WeekendRate,
                Rating = model.Rating,
                PropertyLocation = model.PropertyLocation,
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Properties.Add(property);
                return ctx.SaveChanges() == 1;
            }
        }
        //GET ALL PROPERTIES
        public IEnumerable<PropertyListItem> GetProperties()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Properties
                    .Select(
                        e =>
                        new PropertyListItem
                        {
                            OwnerId = _userId, //needs to use profile id - this is not just for owners

                            PropertyId = e.PropertyId,
                            Title = e.Title,
                            Address = e.Address,
                            NumOfBeds = e.NumOfBeds,
                            Desc = e.Desc,
                            WeekDayRate = e.WeekdayRate,
                            WeekendRate = e.WeekendRate,
                            Rating = e.Rating,
                            PropertyLocation = e.PropertyLocation,
                        }

                        );
                return query.ToArray();
            }
        }
        //GET PROPERTY BY ID
        public PropertyDetail GetPropertyById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var property =
                    ctx
                     .Properties
                     .Single(e => e.PropertyId == id);
                return
                 new PropertyDetail
                 {
                     PropertyId = property.PropertyId,
                     Title = property.Title,
                     Address = property.Address,
                     NumOfBeds = property.NumOfBeds,
                     Desc = property.Desc,
                     WeekDayRate = property.WeekdayRate,
                     WeekendRate = property.WeekendRate,
                     Rating = property.Rating,
                     PropertyLocation = property.PropertyLocation,

                 };
            }
        }
        //GET LIST OF ATTRACTIONS
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public List<AttractionListItem> GetAllAttractions()
        {
            var attractions = _context.Attractions.ToList();
            var attractionList = attractions.Select(s => new AttractionListItem
            {
                AttractionId = s.AttractionId,
                Name = s.Name,
                Type = s.Type,
                AttractionRating = s.AttractionRating,
                AttractionLocation = s.AttractionLocation,
            }).ToList();
            return attractionList;
        }

        //PROPERTY ATTRACTIONS
        public List<Attraction> GetLocationAttractions()
        {
            var getList = GetAllAttractions().ToList();
            var property = new Property();
            var attractionLists = getList.Select(s => new Attraction
            {
                AttractionId = s.AttractionId,
                Name = s.Name,
                Type = s.Type,
                AttractionRating = s.AttractionRating
            }).ToList();

            foreach (AttractionListItem attraction in getList)
            {
                if (attraction.AttractionLocation == property.PropertyLocation)
                {
                    return attractionLists;
                }
            }
            return null;
        }


        //DELETE PROPERTY
        public bool DeleteProperty(int propertyId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Properties
                    .Single(e => e.PropertyId == propertyId);

                ctx.Properties.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        //UPDATE PROPERTY
        public bool UpdateProperty(PropertyEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Properties
                        .Single(e => e.PropertyId == model.PropertyId && e.OwnerId == model.OwnerId);
                entity.Title = model.Title;
                entity.Address = model.Address;
                entity.NumOfBeds = model.NumOfBeds;
                entity.Desc = model.Desc;
                entity.WeekdayRate = model.WeekDayRate;
                entity.WeekendRate = model.WeekendRate;
                entity.Rating = model.Rating;
                entity.PropertyLocation = model.PropertyLocation;

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
