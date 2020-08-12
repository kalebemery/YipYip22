using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip22.Data
{
    public enum Location
    {
        DowntownIndy = 1,
        BroadRipple =2,
        Speedway =3,
        Carmel =4,
        Fishers =5,
        FountainSquare =6,
        Plainfield =7,
        Lawrence =8,
        BeachGrove =9,
        Greenwood =10,
        Avon =11,
        Brownsburg =12,
    }
    public class Attraction
    {
        [Key]
        public int AttractionId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int AttractionRating { get; set; }
        [Required]
        public Location AttractionLocation { get; set; }
    }
}
