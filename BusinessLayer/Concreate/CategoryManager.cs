using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public  class CategoryManager:ICategoryService
    {
        ICategoryDal _CategoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _CategoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _CategoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            throw new NotImplementedException();
        }

        public Category Get(int category)
        {
            return _CategoryDal.Get(x => x.CategoryId == category);
        }

        public List<Category> GetAll()
        {
            return _CategoryDal.GetAll();
        }



        //public CategoryManager(ICategoryDal _categoryDal)
        //{
        //    categoryDal = _categoryDal;
        //}

        //public void Add(Category category)
        //{
        //    categoryDal.Add(category);
        //}

        //public void Delete(Category category)
        //{
        //    categoryDal.Delete(category);
        //}

        //public Category Get(int category)
        //{
        //    return categoryDal.Get(x => x.CategoryId == category);
        //}

        //public List<Category> GetAll()
        //{
        //    return categoryDal.GetAll().ToList();
        //}
    }
}
