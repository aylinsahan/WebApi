using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using WebAPI.Business.Abstract;
using WebAPI.Entities;

namespace WebAPI.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Users Add(Users users)
        {
            return _userRepository.Add(users);
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }

        public IList<Users> GetAll()
        {
            return _userRepository.GetAll();
        }

        public Users GetById(int id)
        {
            return _userRepository.Get(x => x.Id == id);
        }

        public Users GetByUserName(string userName)
        {
            return _userRepository.Get(x => x.UserName == userName);
        }

        public Users Update(Users users)
        {
            return _userRepository.Update(users);
        }
    }
}
