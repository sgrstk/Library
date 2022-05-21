using LibraryWebApplication.Models;
using LibraryWebApplication.Repository.Interfaces;
using LibraryWebApplication.Data;

namespace LibraryWebApplication.Repository
{
    public class AdministratorRepository : RepositoryBase<Administrator>, IAdministratorRepository
    {
        public AdministratorRepository(LibraryContext webDBContext) : base(webDBContext) { }
    }
}
