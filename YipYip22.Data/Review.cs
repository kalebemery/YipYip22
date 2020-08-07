using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip22.Data
{
    public class Review
    {
        public int ReviewId { get; set; }
        [Required]
        [ForeignKey(nameof(Booking))]
        public int BookingId { get; set; }
        public int Rating { get; set; }
        [ForeignKey(nameof(Profile))]
        public int ProfileId { get; set; }
    }
}
