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
        //CREATE
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
        //Get by property Id
        //public List<AttractionListItem> GetAttractionByLocation(List<AttractionLocation> area)
        //{
        //    var attractionLocation = _context.Attractions.Find(area);
        //    var attractionList
        //}

    }
}
