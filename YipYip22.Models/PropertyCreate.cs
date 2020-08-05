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
        //set min and max?
        public string Title { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int NumOfBeds { get; set; }

        [Required]
        //set min and max?
        public string Desc { get; set; }

        [Required]
        public double WeekDayRate { get; set; }

        [Required]
        public double WeekendRate { get; set; }

        //[Required]
        public int Rating { get; set; }
        [Required]
        public Location PropertyLocation { get; set; }

        public int OwnerId { get; set; }
    }
}
