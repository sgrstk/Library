using LibraryWebApplication.Repository.Interfaces;
using LibraryWebApplication.Models;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Linq;
using System;


namespace LibraryWebApplication.Services
{
    public class LibraryService : BaseServices
    {
        public LibraryService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper) { }

        public List<Library> GetLibraries()
        {
            return repositoryWrapper.libraryRepository.FindAll().ToList();
        }

        public List<Library> GetLibrariesByCondition(Expression<Func<Library, bool>> expression)
        {
            return repositoryWrapper.libraryRepository.FindByCondition(expression).ToList();
        }

        public void AddLibrary(Library library)
        {
            repositoryWrapper.libraryRepository.Create(library);
        }

        public void UpdateLibrary(Library library)
        {
            repositoryWrapper.libraryRepository.Update(library);
        }

        public void DeleteLibrary(Library library)
        {
            repositoryWrapper.libraryRepository.Delete(library);
        }

    }
}
