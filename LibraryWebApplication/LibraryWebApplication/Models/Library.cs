using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace LibraryWebApplication.Models
{
    public class Library
    {
        [Key]
#pragma warning disable IDE1006 // Naming Styles
        public int library_id { get; set; }
#pragma warning restore IDE1006 // Naming Styles

#pragma warning disable IDE1006 // Naming Styles
        public int borrowed_book { get; set; }
#pragma warning restore IDE1006 // Naming Styles

#pragma warning disable IDE1006 // Naming Styles
        public int total_nr_of_books { get; set; }
#pragma warning restore IDE1006 // Naming Styles

#pragma warning disable IDE1006 // Naming Styles
        public string return_date { get; set; }
#pragma warning restore IDE1006 // Naming Styles

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning disable IDE1006 // Naming Styles
        public Book? book { get; set; }
        public User? user { get; set; }
        public Administrator? administrator { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

        public int message_id { get; set; }
        public ICollection<Contact> contact { get; set; }
    }
}
