using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryWebApplication.Models
{
    [NotMapped]
    public class Administrator : IdentityUser
    {
        [Key]
#pragma warning disable IDE1006 // Naming Styles
        public int admin_id { get; set; }
        public int library_id { get; set; }
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        public ICollection<Library>? library { get; set; }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
#pragma warning restore IDE1006 // Naming Styles

        [NotMapped]
        public object Ida { get; internal set; }
        [NotMapped]
        public object PasswordHasha
        {
            get; internal set;
        }
    }
}
