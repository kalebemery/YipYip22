using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip22.Models
{
    public class AttractionEdit
    {
        [Display(Name = "AttractionId")]
        public int AttractionId { get; set; }
        [Display(Name = "Name of Attraction")]
        public string Name { get; set; }
        [Display(Name = "Attraction Rating (0 - 5)")]
        public int AttractionRating { get; set; }
    }
}
