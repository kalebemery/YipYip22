using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip22.Data
{
    public class Property
    {
        [Key]
        public int PropertyId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Address { get; set; }
        public int NumOfBeds { get; set; }
        [Required]
        public string Desc { get; set; }
        [Required]
        public double WeekdayRate { get; set; }
        [Required]
        public double WeekendRate { get; set; }
        public int Rating { get; set; }
        public Location PropertyLocation { get; set; }
        [Required]
        [ForeignKey(nameof(Owner))]
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
