using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate.Repositories;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, ProjectContext>, ICategoryDal
    {
        //EfEntityRepositoryBase<Category, ProjectContext>,IEntityRepository<Category>
        public void TESTMURAT()
        {
            throw new NotImplementedException();
        }
       

       
    }
}
