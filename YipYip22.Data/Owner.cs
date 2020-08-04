﻿using System;
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
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string ProfileName { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public int? Rating { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [ForeignKey(nameof(ProfileId))]
        [Required]
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual ICollection<Property> OwnerProperties { get; set; } = new List<Property>();

    }
}