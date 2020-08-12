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
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "ProfileId")]
        public int ProfileId { get; set; }
    }
}
