using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip22.Models
{
    public class OwnerCreate
    {
        [Required]
        [Display(Name = "Owner Name")]
        public string ProfileName { get; set; }
        public int Phone { get; set; }
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int ProfileId { get; set; }
    }
}
