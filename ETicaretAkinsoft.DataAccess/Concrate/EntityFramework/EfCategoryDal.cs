using ETicaretAkinsoft.Core.DataAccess.EntityFramework;
using ETicaretAkinsoft.DataAccess.Abstract;
using ETicaretAkinsoft.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAkinsoft.DataAccess.Concrate.EntityFramework
{
    public class EfCategoryDal :EfEntityRepositoryBase<Category, ETicaretContext>, ICategoryDal
    {
    
    }
}
