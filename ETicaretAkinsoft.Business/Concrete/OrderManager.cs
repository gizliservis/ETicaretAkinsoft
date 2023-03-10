using ETicaretAkinsoft.Business.Abstract;
using ETicaretAkinsoft.Business.Constants;
using ETicaretAkinsoft.Business.ValidationRules.FluentValidation;
using ETicaretAkinsoft.Core.Aspects.Autofac.Caching;
using ETicaretAkinsoft.Core.Aspects.Autofac.Validation;
using ETicaretAkinsoft.Core.Utilities.Business;
using ETicaretAkinsoft.Core.Utilities.Results;
using ETicaretAkinsoft.DataAccess.Abstract;
using ETicaretAkinsoft.DataAccess.Concrete.EntityFramework;
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
        IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        [ValidationAspect(typeof(OrderValidator))]
        [CacheRemoveAspect("IOrderService.Get")]
        public IResult Add(Order order)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }

            _orderDal.Add(order);

            return new SuccessResult();
        }
        [ValidationAspect(typeof(OrderValidator))]
        [CacheRemoveAspect("IOrderService.Get")]
        public IResult Update(Order order)
        {
            var result = _orderDal.GetAll(p => p.OrderId == order.OrderId).Count;
            if (result == 0)
            {
                return new ErrorResult("Güncelleme İşlemi Yapılamadı");
            }
            _orderDal.Update(order);
            throw new NotImplementedException();
        }
    }
}
