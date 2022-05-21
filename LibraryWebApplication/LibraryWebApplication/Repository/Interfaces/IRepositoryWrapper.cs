namespace LibraryWebApplication.Repository.Interfaces
{
    public interface IRepositoryWrapper
    {
        IAuthorRepository authorRepository { get; }
        IAuthorBookRepository authorBookRepository { get; }
        IBookRepository bookRepository { get; }

        IContactsRepository contactsRepository { get; }

        ILibrariesRepository libraryRepository { get; }

        IPublishersRepository publishersRepository { get; }

        IUsersRepository usersRepository { get; }

        IAdministratorRepository administratorRepository { get; }

        void Save();
    }
}
