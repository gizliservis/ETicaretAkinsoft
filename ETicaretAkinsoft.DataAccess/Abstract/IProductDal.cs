using ETicaretAkinsoft.Core.DataAccess;
using ETicaretAkinsoft.Entities.Concrete;
using ETicaretAkinsoft.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaretAkinsoft.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}

//Code Refactoring
