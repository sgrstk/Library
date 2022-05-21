using System.ComponentModel.DataAnnotations;

namespace LibraryWebApplication.Models
{
    public class Publisher
    {
        [Key]
#pragma warning disable IDE1006 // Naming Styles
        public string publisher_name { get; set; }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        public string address { get; set; }
#pragma warning restore IDE1006 // Naming Styles

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        public Book? book { get; set; }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
    }
}
