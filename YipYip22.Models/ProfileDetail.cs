using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip22.Models
{
    public class ProfileDetail
    {
        [Display(Name = "Profile ID")]
        public int ProfileId { get; set; }
        [Display(Name = "Name")]
        public string ProfileName { get; set; }
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Rating")]
        public int Rating { get; set; }
    }
}
