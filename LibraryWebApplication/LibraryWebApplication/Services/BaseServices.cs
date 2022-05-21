using LibraryWebApplication.Repository.Interfaces;

namespace LibraryWebApplication.Services
{
    public class BaseServices
    {
        protected IRepositoryWrapper repositoryWrapper;

        public BaseServices(IRepositoryWrapper repository)
        {
            repositoryWrapper = repository;
        }

        public void Save()
        {
            repositoryWrapper.Save();
        }
    }
}
