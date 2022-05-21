using LibraryWebApplication.Models;
using LibraryWebApplication.Repository.Interfaces;
using LibraryWebApplication.Data;

namespace LibraryWebApplication.Repository
{
    public class UserRepository : RepositoryBase<User>, IUsersRepository
    {
        public UserRepository(LibraryContext webDBContext) : base(webDBContext) { }
    }
}
