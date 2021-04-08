using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
        IDataResult<List<User>> GetAll();
        IResult Add(User user);      
        IResult Delete(User user);
        IResult Update(User user);
        IDataResult<List<UserDetailDto>> GetUserDetails(int id);

    }
}
