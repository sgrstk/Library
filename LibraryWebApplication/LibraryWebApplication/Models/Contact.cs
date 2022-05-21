using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace LibraryWebApplication.Models
{
    public class Contact
    {
        [Key]
        public int message_id { get; set; }
        
        public string first_name { get; set; }

        public string last_name { get; set; }

        public string email { get; set; }

        public string subject { get; set; }

        public Library? Library { get; set; }

        public int user_id;
#pragma warning disable IDE1006 // Naming Styles
        public ICollection<User> user { get; set; }
#pragma warning restore IDE1006 // Naming Styles
    }
}
