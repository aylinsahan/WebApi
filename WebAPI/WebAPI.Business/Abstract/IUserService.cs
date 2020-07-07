using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Entities;

namespace WebAPI.Business.Abstract
{
    public interface IUserService
    {
        IList<Users> GetAll();
        Users GetById(int id);
        Users GetByUserName(string userName);
        Users Add(Users users);
        Users Update(Users users);
        void Delete(int id);
    }
}
