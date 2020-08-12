using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using YipYip22.Data;
using YipYip22.Models;

namespace YipYip22.Services
{
    public class AttractionService
    {
        private readonly Guid _userId;
        public AttractionService(Guid userId)
        {
            _userId = userId;
        }
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        //CREATE ATTRACTION
        public bool CreateAttraction(AttractionCreate model)
        {
            Attraction attraction = new Attraction
            {
                Name = model.Name,
                Type = model.Type,
                AttractionRating = model.AttractionRating,
                AttractionLocation = model.AttractionLocation
            };
            using (ApplicationDbContext ctx = new ApplicationDbContext())
            {
                ctx.Attractions.Add(attraction);
                return ctx.SaveChanges() == 1;
            }
        }
        //GET LIST OF ATTRACTIONS
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
        //UPDATE ATTRACTION
        public bool UpdateAttraction(AttractionEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Attractions.Single(e => e.AttractionId == model.AttractionId);
                entity.AttractionId = model.AttractionId;
                entity.Name = model.Name;
                entity.AttractionRating = model.AttractionRating;
                return ctx.SaveChanges() == 1;
            }
        }
        //DELETE ATTRACTION
        public bool DeleteAttraction(int attractionId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Attractions
                    .Single(e => e.AttractionId == attractionId);
                ctx.Attractions.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
