using System.Linq;
using Test.Test.Core;
using Test.Test.Domain;

namespace Test.Test.Tools
{
    class Authentificator : IAuthentificator
    {
        private readonly IRepository _repository;

        public Authentificator(IRepository repository)
        {
            _repository = repository;
        }

        public void RegisterUser(User user)
        {
            if(_repository.GetUsers().ToList().Any( it => it.UserName == user.UserName))
            {
                throw new UserAlreadyExist();
            }
            _repository.AddUser(user);
        }
    }
}