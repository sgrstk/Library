using LibraryWebApplication.Models;
using LibraryWebApplication.Repository.Interfaces;
using LibraryWebApplication.Data;

namespace LibraryWebApplication.Repository
{
    public class AuthorBookRepository : RepositoryBase<AuthorBook>, IAuthorBookRepository
    {
        public AuthorBookRepository(LibraryContext webDBContext) : base(webDBContext) { }
    }
}
