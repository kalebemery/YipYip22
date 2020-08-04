using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YipYip22.Data;

namespace YipYip22.Models
{
    public class AttractionCreate
    {
        [Required]
        [Display(Name = "Name of Attraction")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Type of Attraction")]
        public string Type { get; set; }
        [Required]
        [Display(Name = "Rating")]
        [Range(0, 5, ErrorMessage = "Please enter a rating between 1-5")]
        public int AttractionRating { get; set; }
        [Required]
        public Location AttractionLocation { get; set; }
    }
}
