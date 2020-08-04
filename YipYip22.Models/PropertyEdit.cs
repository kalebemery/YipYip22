using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YipYip22.Data;

namespace YipYip22.Models
{
    public class PropertyEdit
    {
        [Required]
        public int PropertyId { get; set; }
        [Required]
        public int OwnerId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int NumOfBeds { get; set; }
        [Required]
        public string Desc { get; set; }
        [Required]
        public double WeekDayRate { get; set; }
        [Required]
        public double WeekendRate { get; set; }
        //[Required]
        public int Rating { get; set; }
        public Location PropertyLocation { get; set; }
    }
}
