using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RequiredFiledsTest.Models
{
    public class SignUp
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public bool WantsNewsletter { get; set; }

        /// <summary>
        /// Email is going to be required only if they want to receive a newsletter
        /// </summary>
        public string Email { get; set; }
    }
}