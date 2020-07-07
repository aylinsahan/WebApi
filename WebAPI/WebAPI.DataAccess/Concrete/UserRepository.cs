using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Core.DataAccess.Concrete;
using WebAPI.DataAccess;
using WebAPI.Entities;

namespace WebAPI.Business.Repositories
{
    public class UserRepository :BaseRepository<Users, WebApiContext>, IUserRepository
    {
     
    }
}
