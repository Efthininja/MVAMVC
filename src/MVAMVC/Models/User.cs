using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVAMVC.Models
{
    public class User
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20), MinLength(2)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Confirm { get; set; }
    }
}
