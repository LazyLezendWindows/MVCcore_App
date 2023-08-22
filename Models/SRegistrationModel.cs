
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCore_App.Models
{
    public class SRegistrationModel
    {
        [Key]
        public int RollNo { get; set; }
        [MaxLength(20)]
        [DisplayName ("Student Name")]
        public string StudentName { get; set; }= string.Empty;

        public DateTime DoB { get; set; } 

        public char Gender { get; set; }
        public int Age { get; set;}

        public string Address { get; set; } = string.Empty;
        public string City { get; set; }=string.Empty;

        public string State { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;


    }
}
