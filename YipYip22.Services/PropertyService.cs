using System;
using System.Collections.Generic;
using System.Linq;
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
        public IEnumerable<PropertyListItem> GetPropertyByOwner()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                     .Properties
                     .Select
                     (e =>

                new PropertyListItem
                {
                    PropertyId = e.PropertyId,
                    Title = e.Title,
                    Address = e.Address,
                    NumOfBeds = e.NumOfBeds,
                    Desc = e.Desc,
                    WeekDayRate = e.WeekdayRate,
                    WeekendRate = e.WeekendRate,
                    Rating = e.Rating,
                    PropertyLocation = e.PropertyLocation

                }
                );
                foreach(PropertyListItem properties in query)
                    if(proper)
                 
                return query.ToList();
            }
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
