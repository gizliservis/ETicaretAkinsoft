using ETicaretAkinsoft.Core.DataAccess.EntityFramework;
using ETicaretAkinsoft.DataAccess.Abstract;
using ETicaretAkinsoft.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ETicaretAkinsoft.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, AkinsoftContext>, ICategoryDal
    {
        
    }
}
