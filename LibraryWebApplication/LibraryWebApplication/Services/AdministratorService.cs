using LibraryWebApplication.Repository.Interfaces;
using LibraryWebApplication.Models;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Linq;
using System;

namespace LibraryWebApplication.Services
{
    public class AdministratorService:BaseServices
    {
        public AdministratorService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper) { }
        public List<Administrator> GetAdministrator()
        {
            return repositoryWrapper.administratorRepository.FindAll().ToList();
        }
        public List<Administrator> GetAdministratorByCondition(Expression<Func<Administrator, bool>> expression)
        {
            return repositoryWrapper.administratorRepository.FindByCondition(expression).ToList();
        }
        public void AddAdministrator(Administrator admin)
        {
            repositoryWrapper.administratorRepository.Create(admin);
        }
        public void UpdateAdministrator(Administrator admin)
        {
            repositoryWrapper.administratorRepository.Update(admin);
        }

        public void DeleteAdministrator(Administrator admin)
        {
            repositoryWrapper.administratorRepository.Delete(admin);
        }
    }
}
