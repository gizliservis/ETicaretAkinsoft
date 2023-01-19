using ETicaretAkinsoft.Core.DataAccess;
using ETicaretAkinsoft.Entities.Concrate;
using ETicaretAkinsoft.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAkinsoft.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
