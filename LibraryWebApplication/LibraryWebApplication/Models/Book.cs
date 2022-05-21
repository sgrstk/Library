using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace LibraryWebApplication.Models
{
    public class Book
    {
        [Key]
        public int book_id { get; set; }

        public string? title { get; set; }

        public string? genre { get; set; }

        public string? release_year { get; set; }

        public string publisher_name { get; set; }
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        public ICollection<Publisher>? publishers { get; set; }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

        public int library_id { get; set; }
        public ICollection<Library>? librarys { get; set; }

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        public AuthorBook? AuthorBook { get; set; }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
    }
}
