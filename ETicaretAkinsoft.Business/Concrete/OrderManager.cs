using ETicaretAkinsoft.Business.Abstract;
using ETicaretAkinsoft.Business.ValidationRules.FluentValidation;
using ETicaretAkinsoft.Core.Aspects.Autofac.Caching;
using ETicaretAkinsoft.Core.Aspects.Autofac.Validation;
using ETicaretAkinsoft.Core.Utilities.Results;
using ETicaretAkinsoft.Entities.Concrate;
using ETicaretAkinsoft.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAkinsoft.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        [ValidationAspect(typeof(OrderValidator))]
        [CacheRemoveAspect("IOrderService.Get")]
        public IResult Add(Order order)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
