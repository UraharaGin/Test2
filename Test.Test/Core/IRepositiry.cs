using System.Collections.Generic;
using Test.Test.Domain;

namespace Test.Test.Core
{
    public interface IRepository
    {
        void AddUser(User user);

        IEnumerable<User> GetUsers();
    }
}