using ETicaretAkinsoft.Core.DataAccess.EntityFramework;
using ETicaretAkinsoft.DataAccess.Abstract;
using ETicaretAkinsoft.Entities.Concrete;
using ETicaretAkinsoft.Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ETicaretAkinsoft.DataAccess.Concrete.EntityFramework
{
    //NuGet
    public class EfProductDal : EfEntityRepositoryBase<Product, AkinsoftContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (AkinsoftContext context = new AkinsoftContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto 
                             {
                                 ProductId = p.ProductId, ProductName = p.ProductName, 
                                 CategoryName =c.CategoryName, UnitsInStock = p.UnitsInStock 
                             };
                return result.ToList();
            }
        }
    }
}
