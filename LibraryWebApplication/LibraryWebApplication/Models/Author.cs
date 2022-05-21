using System.ComponentModel.DataAnnotations;
namespace LibraryWebApplication.Models
{
    public class Author
    {
        [Key]
        public int author_id { get; set; }
        public string? name { get; set; }

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        public AuthorBook? authorBooks { get; set; }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
    }
}
