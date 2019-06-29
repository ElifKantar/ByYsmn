using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ByYsmn.Core.Identity
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

    }
}
