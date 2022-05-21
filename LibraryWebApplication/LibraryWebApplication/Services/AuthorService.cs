using LibraryWebApplication.Repository.Interfaces;
using LibraryWebApplication.Models;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Linq;
using System;

namespace LibraryWebApplication.Services
{
    public class AuthorService : BaseServices
    {
        public AuthorService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper) { }
        public List<Author> GetAuthors()
        {
            return repositoryWrapper.authorRepository.FindAll().ToList();
        }
        public List<Author> GetAuthorsByCondition(Expression<Func<Author, bool>> expression)
        {
            return repositoryWrapper.authorRepository.FindByCondition(expression).ToList();
        }

        public void AddAuthor(Author author)
        {
            repositoryWrapper.authorRepository.Create(author);
        }

        public void UpdateAuthor(Author author)
        {
            repositoryWrapper.authorRepository.Update(author);
        }

        public void DeleteAuthor(Author author)
        {
            repositoryWrapper.authorRepository.Delete(author);
        }

    }
}
