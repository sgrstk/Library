using LibraryWebApplication.Repository.Interfaces;
using LibraryWebApplication.Data;

namespace LibraryWebApplication.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private LibraryContext _context;
        private IAdministratorRepository AdministratorRepository;
        private IAuthorBookRepository AuthorBookRepository;
        private IAuthorRepository AuthorRepository;
        private IBookRepository BookRepository;
        private IContactsRepository ContactsRepository;
        private ILibrariesRepository LibrariesRepository;
        private IPublishersRepository PublishersRepository;
        private IUsersRepository UsersRepository;

        public IUsersRepository usersRepository
        {
            get {

                if (UsersRepository == null)
                {
                    UsersRepository = new UserRepository(_context);
                }
                return UsersRepository; 
            }
        }

        public IAdministratorRepository administratorRepository
        {
            get
            {
                if (AdministratorRepository == null)
                {
                    AdministratorRepository = new AdministratorRepository(_context);
                }
                return AdministratorRepository;
            }
        }

        public IAuthorBookRepository authorBookRepository
        {
            get
            {
                if (AuthorBookRepository == null)
                {
                    AuthorBookRepository = new AuthorBookRepository(_context);
                }
                return AuthorBookRepository;
            }
        }

        public IPublishersRepository publishersRepository
        {
            get
            {
                if (PublishersRepository == null)
                {
                    PublishersRepository = new PublisherRepository(_context);
                }
                return PublishersRepository;
            }
        }

        public IAuthorRepository authorRepository
        {
            get
            {
                if (AuthorRepository == null)
                {
                    AuthorRepository = new AuthorRepository(_context);
                }
                return AuthorRepository;
            }
        }

        public IContactsRepository contactsRepository
        {
            get
            {
                if (ContactsRepository == null)
                {
                    ContactsRepository=new ContactRepository(_context);
                }
                return ContactsRepository;
            }
        }

        public IBookRepository bookRepository
        {
            get { 
                if (BookRepository == null)
                {
                    BookRepository = new BookRepository(_context); 
                }
                return BookRepository; 
            }
        }

        public ILibrariesRepository libraryRepository
        {
            get
            {
                if (LibrariesRepository == null)
                {
                    LibrariesRepository=new LibraryRepository(_context);
                }
                return LibrariesRepository;
            }
        }

        public RepositoryWrapper(LibraryContext webDBContext)
        {
            _context = webDBContext;
        }
        public void Save()
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            _context.SaveChanges();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }


    }
}
