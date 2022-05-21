using LibraryWebApplication.Repository.Interfaces;
using LibraryWebApplication.Models;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Linq;
using System;

namespace LibraryWebApplication.Services
{
    public class BookService : BaseServices
    {
        public BookService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper) { }
        public List<Book> GetBooks()
        {
            return repositoryWrapper.bookRepository.FindAll().ToList();
        }
        public List<Book> GetBooksByCondition(Expression<Func<Book, bool>> expression)
        {
            return repositoryWrapper.bookRepository.FindByCondition(expression).ToList();
        }
        public void AddBook(Book book)
        {
            repositoryWrapper.bookRepository.Create(book);
        }

        public void UpdateBook(Book book)
        {
            repositoryWrapper.bookRepository.Update(book);
        }
        public void DeleteBook(Book book)
        {
            repositoryWrapper.bookRepository.Delete(book);
        }
    }
}
