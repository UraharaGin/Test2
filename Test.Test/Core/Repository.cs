using System.Collections.Generic;
using Test.Test.Domain;

namespace Test.Test.Core
{
    class Repository : IRepository
    {
        private readonly DataBaseContext _dataBaseContext;

        public Repository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public IEnumerable<User> GetUsers()
        {
            return _dataBaseContext.Users;
        }

        public void AddUser(User user)
        {
            _dataBaseContext.Users.Add(user);
            _dataBaseContext.SaveChanges();
        }
    }
}