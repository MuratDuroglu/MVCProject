using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public  interface ICategoryService
    {

        void Add(Category category);

        void Delete(Category category);


        Category Get(int category);


        List<Category> GetAll();

        void CategoryUpdate(Category category);


    }
}
