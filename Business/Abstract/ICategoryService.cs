using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> getCategories();
        Category GetByCategoryId(int id);
        //List<Category> getByUnitPrice(decimal min, decimal max);

    }
}
