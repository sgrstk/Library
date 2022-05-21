using LibraryWebApplication.Models;
using LibraryWebApplication.Repository.Interfaces;
using LibraryWebApplication.Data;

namespace LibraryWebApplication.Repository
{
    public class LibraryRepository : RepositoryBase<Library>, ILibrariesRepository
    {
        public LibraryRepository(LibraryContext webDBContext) : base(webDBContext) { }
    }
}
