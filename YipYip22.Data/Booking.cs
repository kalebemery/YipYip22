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
        public int BookingID { get; set; }
        [Required]
        [ForeignKey(nameof(Profile))]
        public int ProfileId { get; set; }
        [Required]
        [ForeignKey(nameof(Property))]
        public int PropertyId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public double WeekdayRate { get; set; }
        [Required]
        public double WeekendRate { get; set; }
        [Required]
        public int? NumOfWeekday { get; set; }
        [Required]
        public int? NumofWeekend { get; set; }
    }
}
