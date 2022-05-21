using LibraryWebApplication.Repository.Interfaces;
using LibraryWebApplication.Models;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Linq;
using System;

namespace LibraryWebApplication.Services
{
    public class AuthorBookService : BaseServices
    {
        public AuthorBookService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper) { }
        public List<AuthorBook> GetAuthorBooks()
        {
            return repositoryWrapper.authorBookRepository.FindAll().ToList();
        }

        public List<AuthorBook> GetAuthorBooksByCondition(Expression<Func<AuthorBook, bool>> expression)
        {
            return repositoryWrapper.authorBookRepository.FindByCondition(expression).ToList();
        }

        public void AddAuthorBook(AuthorBook authorBook)
        {
            repositoryWrapper.authorBookRepository.Create(authorBook);
        }

        public void UpdateAuthorBook(AuthorBook authorBook)
        {
            repositoryWrapper.authorBookRepository.Update(authorBook);
        }

        public void DeleteAuthorBook(AuthorBook authorBook)
        {
            repositoryWrapper.authorBookRepository.Delete(authorBook);
        }
    }
}
