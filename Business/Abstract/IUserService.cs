using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        User GetByMail(string email);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetUsersById(int id);

    }
}