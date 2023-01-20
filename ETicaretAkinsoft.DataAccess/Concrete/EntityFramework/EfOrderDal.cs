using ETicaretAkinsoft.Core.DataAccess.EntityFramework;
using ETicaretAkinsoft.DataAccess.Abstract;
using ETicaretAkinsoft.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaretAkinsoft.DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal:EfEntityRepositoryBase<Order, AkinsoftContext>,IOrderDal
    {
    }
}
