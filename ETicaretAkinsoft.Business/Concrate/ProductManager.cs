using ETicaretAkinsoft.Business.Abstract;
using ETicaretAkinsoft.Core.Utilities.Results;
using ETicaretAkinsoft.DataAccess.Abstract;
using ETicaretAkinsoft.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAkinsoft.Business.Concrate
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {

            if (product.ProductName.Length<2)
            {
                return new ErrorResult("Ürün İsmi En Az 2 Karakter Olmalıdır");
            }
           _productDal.Add(product);
            return new Result(true, "Eklendi");

        }

        public List<Product> GetAll()
        {
           return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p=>p.CategoryId==id);
        }

        public List<Product> GetAllByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice<=max);
        }

        public List<Product> GetById(int productId)
        {
            return _productDal.GetAll(p=>p.ProductId==productId);
        }
    }
}
