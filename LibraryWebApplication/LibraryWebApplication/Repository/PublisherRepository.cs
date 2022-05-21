using LibraryWebApplication.Models;
using LibraryWebApplication.Repository.Interfaces;
using LibraryWebApplication.Data;

namespace LibraryWebApplication.Repository
{
    public class PublisherRepository : RepositoryBase<Publisher>, IPublishersRepository
    {
        public PublisherRepository(LibraryContext webDBContext) : base(webDBContext) { }
    }
}
