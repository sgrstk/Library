using LibraryWebApplication.Repository.Interfaces;
using LibraryWebApplication.Models;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Linq;
using System;

namespace LibraryWebApplication.Services
{
    public class PublisherService : BaseServices
    {
        public PublisherService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper) { }

        public List<Publisher> GetPublisher()
        {
            return repositoryWrapper.publishersRepository.FindAll().ToList();
        }

        public List<Publisher> GetPublisherByCondition(Expression<Func<Publisher, bool>> expression)
        {
            return repositoryWrapper.publishersRepository.FindByCondition(expression).ToList();
        }

        public void AddPublisher(Publisher editure)
        {
            repositoryWrapper.publishersRepository.Create(editure);
        }

        public void UpdatePublisher(Publisher editure)
        {
            repositoryWrapper.publishersRepository.Update(editure);
        }

        public void DeletePublisher(Publisher editure)
        {
            repositoryWrapper.publishersRepository.Delete(editure);
        }

    }
}
