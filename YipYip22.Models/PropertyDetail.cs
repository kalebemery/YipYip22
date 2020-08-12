using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YipYip22.Data;

namespace YipYip22.Models
{
    public class PropertyDetail
    {
        [Display(Name = "Property ID")]
        public int PropertyId { get; set; }
        [Display(Name = "Owner ID")]
        public int OwnerId { get; set; }
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Number of beds")]
        public int NumOfBeds { get; set; }
        [Display(Name = "Description")]
        public string Desc { get; set; }
        [Display(Name = "Week Day Rate")]
        public double WeekDayRate { get; set; }
        [Display(Name = "Weekend Rate")]
        public double WeekendRate { get; set; }
        [Display(Name = "Rating")]
        public int Rating { get; set; }
        [Display(Name = "PropertyLocation")]
        public Location PropertyLocation { get; set; }
        [Display(Name = "Attraction")]
        public List<Attraction> Attraction { get; set; }
    }
}
