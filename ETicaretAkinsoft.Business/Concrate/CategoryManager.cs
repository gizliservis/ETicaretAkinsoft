using ETicaretAkinsoft.Business.Abstract;
using ETicaretAkinsoft.DataAccess.Abstract;
using ETicaretAkinsoft.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAkinsoft.Business.Concrate
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public List<Category> GetById(int categoryId)
        {
            return _categoryDal.GetAll(c=>c.CategoryId== categoryId);
        }
    }
}
