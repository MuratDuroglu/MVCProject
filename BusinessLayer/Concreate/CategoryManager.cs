using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public   class CategoryManager:ICategoryService
    {
        ICategoryDal categoryDal;

        public CategoryManager( ICategoryDal _categoryDal)
        {
            categoryDal = _categoryDal;
        }

        public void Add(Category category)
        {
            categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            categoryDal.Delete(category);
        }

        public Category Get(int category)
        {
            return categoryDal.Get(x => x.CategoryId == category);
        }

        public List<Category> GetAll()
        {
            return categoryDal.GetAll();
        }
    }
}
