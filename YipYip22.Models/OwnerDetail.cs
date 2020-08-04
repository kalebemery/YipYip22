using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YipYip22.Data;

namespace YipYip22.Models
{
    public class OwnerDetail
    {
        public int OwnerId { get; set; }
        public Guid Id { get; set; }
        [Required]
        public string ProfileName { get; set; }
        public int Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public int? Rating { get; set; }
        public DateTime Created { get; set; }
        public virtual ICollection<Property> OwnerProperties { get; set; } = new List<Property>();
    }
}
