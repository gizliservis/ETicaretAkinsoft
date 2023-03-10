using ETicaretAkinsoft.Core.Utilities.Results;
using ETicaretAkinsoft.Entities.Concrete;
using ETicaretAkinsoft.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaretAkinsoft.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult AddTransactionalTest(Product product);

    }
}
