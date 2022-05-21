using LibraryWebApplication.Repository.Interfaces;
using LibraryWebApplication.Models;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.AspNetCore.Identity;

namespace LibraryWebApplication.Services
{
    public class UserService : BaseServices
    {
        public UserService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper) { }
        public List<User> GetUsers()
        {
            return repositoryWrapper.usersRepository.FindAll().ToList();
        }
        public List<User> GetUsersByCondition(Expression<Func<User, bool>> expression)
        {
            return repositoryWrapper.usersRepository.FindByCondition(expression).ToList();
        }
        public void AddUser(User user)
        {
            repositoryWrapper.usersRepository.Create(user);
        }
        public void UpdateUser(User user)
        {
            repositoryWrapper.usersRepository.Update(user);
        }

        public void DeleteUser(User user)
        {
            repositoryWrapper.usersRepository.Delete(user);
        }
    }
}
