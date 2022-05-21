using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace LibraryWebApplication.Models
{
    [NotMapped]
    public class User : IdentityUser
    {
        [Key]
        public int user_id { get; set; }

        public int library_id { get; set; }
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        public ICollection<Library>? library { get; set; }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

        public string name { get; set; }
        public string email { get; set; }

        public string password { get; set; }

        public Contact contact { get; set; }

        [NotMapped]
        public object Ida { get; internal set; }
        [NotMapped]
        public object PasswordHasha
        {
            get; internal set;
        }
    }
}
