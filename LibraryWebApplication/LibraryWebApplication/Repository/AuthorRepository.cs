using LibraryWebApplication.Models;
using LibraryWebApplication.Repository.Interfaces;
using LibraryWebApplication.Data;

namespace LibraryWebApplication.Repository
{
    public class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
    {
        public AuthorRepository(LibraryContext webDBContext) : base(webDBContext) { }
    }
}
