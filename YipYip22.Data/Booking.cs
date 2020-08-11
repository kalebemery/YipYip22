using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip22.Data
{
    public class Booking
    {
        [Key]
        [ForeignKey(nameof(Profile))]
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
        [ForeignKey(nameof(Property))]
        public int PropertyId { get; set; }
        public Property Property { get; set; }
        [Required]
        public int BookingId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public double WeekendPrice { get; set; }
        [Required]
        public double WeekDayPrice { get; set; }
        public int? NumOfWeekend { get; set; }
        public int? NumOfWeekDay { get; set; }
        public double TotalPrice { get; set; }
    }
}
