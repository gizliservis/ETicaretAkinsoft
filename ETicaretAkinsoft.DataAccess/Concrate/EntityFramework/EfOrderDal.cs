using ETicaretAkinsoft.Core.DataAccess.EntityFramework;
using ETicaretAkinsoft.DataAccess.Abstract;
using ETicaretAkinsoft.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAkinsoft.DataAccess.Concrate.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, ETicaretContext>,IOrderDal
    {
    }
}
