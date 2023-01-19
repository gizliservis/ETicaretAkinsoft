using ETicaretAkinsoft.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAkinsoft.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        List<Category> GetById(int categoryId);


    }
}
