using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip22.Models
{
    public class OwnerEdit
    {
        [Display(Name = "OwnerId")]
        public int OwnerId { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string ProfileName { get; set; }
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
