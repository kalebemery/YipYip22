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
        [Display(Name = "OwnerId")]
        public int OwnerId { get; set; }
        [Display(Name = "Id")]
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "ProfileName")]
        public string ProfileName { get; set; }
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Created")]
        public DateTime Created { get; set; }
        [Display(Name = "Properties")]
        public List<Property> OwnerProperties { get; set; }
    }
}
