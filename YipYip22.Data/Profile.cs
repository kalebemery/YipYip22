using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip22.Data
{
    public class Profile
    {
        [Key]
        public int ProfileId { get; set; }
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string ProfileName { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public int Rating { get; set; }
    }
}

//Listitem(1) handle the task of collecting property data for a list of notes.Used for (GET NOTES)

//Create(2)
//For Create models, we will not include the Id(Key). The id will be created after the POST request happens.

//NoteDetail(3) This will let us view all the properties of the note.(GET NOTE BY ID)

//NoteEdit(4)  allow us to update a note.

//No model needed in order to delete
