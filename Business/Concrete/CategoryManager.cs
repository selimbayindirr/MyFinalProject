using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> getCategories()
        {
            return _categoryDal.GetAll();

        }
        public Category GetByCategoryId(int id)
        {
            return _categoryDal.Get(p=>p.CategoryId == id);
        }


    }
}
