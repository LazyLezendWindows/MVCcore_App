using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MVCcore_App.Models.DTO
{
    public class StudentDTO
    {
        [MaxLength(20)]
        [DisplayName("Student Name")]
        public string StudentName { get; set; } = string.Empty;

        public DateTime DoB { get; set; }

        public char Gender { get; set; }
        public int Age { get; set; }

        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;
    }
}
