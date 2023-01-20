using ETicaretAkinsoft.Core.DataAccess.EntityFramework;
using ETicaretAkinsoft.DataAccess.Abstract;
using ETicaretAkinsoft.Entities.Concrate;
using ETicaretAkinsoft.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAkinsoft.DataAccess.Concrete.EntityFramework
{
    public class EfOrderDetailDal: EfEntityRepositoryBase<OrderDetail, AkinsoftContext>, IOrderDetailDal
    {
    }
}
