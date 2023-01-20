using ETicaretAkinsoft.Business.Abstract;
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
    public class OrderDetailManager : IOrderDetailService
    {
        IOrderDetailDal _orderDetailDal;
        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }
        [ValidationAspect(typeof(OrderDetailValidator))]
        [CacheRemoveAspect("IOrderDetailService.Get")]
        public IResult Add(OrderDetail orderDetail)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }

            _orderDetailDal.Add(orderDetail);

            return new SuccessResult();
        }

        public IResult Update(OrderDetail orderDetail)
        {
            var result = _orderDetailDal.GetAll(p => p.OrderDetailId == orderDetail.OrderDetailId).Count;
            if (result == 0)
            {
                return new ErrorResult("Güncelleme İşlemi Yapılamadı");
            }
            _orderDetailDal.Update(orderDetail);
            throw new NotImplementedException();
        }
    }
}
