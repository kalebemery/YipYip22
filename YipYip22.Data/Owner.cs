using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip22.Data
{
    public class Owner
    {
        [Key]
        public int OwnerId { get; set; }
        public Guid Id { get; set; }

        [ForeignKey(nameof(ProfileId))]
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }

        public virtual ICollection<Property> OwnerProperties { get; set; } = new List<Property>();

       
    }
}
