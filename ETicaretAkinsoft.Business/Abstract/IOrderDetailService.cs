using ETicaretAkinsoft.Core.Utilities.Results;
using ETicaretAkinsoft.Entities.Concrate;
using ETicaretAkinsoft.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAkinsoft.Business.Abstract
{
    public interface IOrderDetailService
    {
        IResult Add(OrderDetail orderDetail);
        IResult Update(OrderDetail orderDetail);
    }
}
