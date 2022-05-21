using LibraryWebApplication.Models;
using LibraryWebApplication.Repository.Interfaces;
using LibraryWebApplication.Data;

namespace LibraryWebApplication.Repository
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(LibraryContext webDBContext) : base(webDBContext) { }
    }
}
