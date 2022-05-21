using LibraryWebApplication.Repository.Interfaces;
using LibraryWebApplication.Models;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Linq;
using System;

namespace LibraryWebApplication.Services
{
    public class ContactService : BaseServices
    {
        public ContactService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper) { }

        public List<Contact> GetMessages()
        {
            return repositoryWrapper.contactsRepository.FindAll().ToList();
        }

        public List<Contact> GetMessagesByCondition(Expression<Func<Contact, bool>> expression)
        {
            return repositoryWrapper.contactsRepository.FindByCondition(expression).ToList();
        }

        public void AddMessage(Contact message)
        {
            repositoryWrapper.contactsRepository.Create(message);
        }
        public void UpdateMessage(Contact message)
        {
            repositoryWrapper.contactsRepository.Update(message);
        }
        public void DeleteMessage(Contact message)
        {
            repositoryWrapper.contactsRepository.Delete(message);
        }
    }
}
