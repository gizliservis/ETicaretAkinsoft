using ETicaretAkinsoft.Core.DataAccess.EntityFramework;
using ETicaretAkinsoft.DataAccess.Abstract;
using ETicaretAkinsoft.Entities.Concrate;
using ETicaretAkinsoft.Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAkinsoft.DataAccess.Concrate.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ETicaretContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (ETicaretContext context=new ETicaretContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitsInStock = p.UnitsInStock,
                             };
                return result.ToList();
            }
           
        }
    }
}
