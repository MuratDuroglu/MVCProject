using DataAccessLayer.Concreate;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public  interface IHeadingDal:IEntityRepository<Heading>
    {

        List<Heading> Include(Expression<Func<Heading, bool>> filter = null);

    }
}
