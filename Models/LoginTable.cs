using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Serialization;
using System.ComponentModel;
using MVCcore_App.Models;

namespace MVCcore_App.Models
{
    [Keyless]
    public class LoginTable
    {
        [Required]
      public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public bool StayLoggedIn { get; set; }
    }
}
