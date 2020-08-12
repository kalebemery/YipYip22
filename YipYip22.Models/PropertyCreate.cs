using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YipYip22.Data;

namespace YipYip22.Models
{
    public class PropertyCreate
    {
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "NumOfBeds")]
        public int NumOfBeds { get; set; }
        [Required]
        //set min and max?
        [Display(Name = "Desc")]
        public string Desc { get; set; }
        [Required]
        [Display(Name = "WeekDayRate")]
        public double WeekDayRate { get; set; }
        [Required]
        [Display(Name = "WeekendRate")]
        public double WeekendRate { get; set; }
        //[Required]
        [Display(Name = "Rating")]
        public int Rating { get; set; }
        [Display(Name = "Location")]
        public Location PropertyLocation { get; set; }
        public int OwnerId { get; set; }
    }
}
