using System;
using System.ComponentModel.DataAnnotations;

namespace MVAMVC.Models
{
    public class User
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20), MinLength(2)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Required]
        public DateTime DateRegistered { get; set; }
    }
}
