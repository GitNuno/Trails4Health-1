using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trails4Health.Models
{
    public class SignIn
    {
        [Required(ErrorMessage = "Please enter your username")]
        //Empty
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username should be 3-50 characters")]
        //Lenght
        public string UserName { get; set; }


        [StringLength(50, MinimumLength = 3, ErrorMessage = "Password should be 3-50 characters")]
        //Empty
        [Required(ErrorMessage = "Please enter your password")]
        //Lenght
        public string UserPass { get; set; }

    }
}
