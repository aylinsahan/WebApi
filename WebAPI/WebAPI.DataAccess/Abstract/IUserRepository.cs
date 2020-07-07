using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Core.DataAccess.Abstract;
using WebAPI.Entities;

namespace WebAPI.Business
{
    public interface IUserRepository: IBaseRepository<Users>
    {
    }
}
