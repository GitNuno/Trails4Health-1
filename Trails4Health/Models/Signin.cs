using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trails4Health.Models
{
    public class SignIn
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter your password")]
        public string UserPass { get; set; }

    }
}
