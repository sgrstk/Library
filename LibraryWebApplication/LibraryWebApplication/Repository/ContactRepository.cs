using LibraryWebApplication.Models;
using LibraryWebApplication.Repository.Interfaces;
using LibraryWebApplication.Data;

namespace LibraryWebApplication.Repository
{
    public class ContactRepository : RepositoryBase<Contact>, IContactsRepository
    {
        public ContactRepository(LibraryContext webDBContext) : base(webDBContext) { }
    }
}
