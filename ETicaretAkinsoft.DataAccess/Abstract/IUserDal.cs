using ETicaretAkinsoft.Core.DataAccess;
using ETicaretAkinsoft.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaretAkinsoft.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
