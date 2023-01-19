using ETicaretAkinsoft.Core.Entities.Concrete;
using System.Collections.Generic;

namespace ETicaretAkinsoft.Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
