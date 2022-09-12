using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate.Repositories;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate
{
    public class EfHeadingDal : EfEntityRepositoryBase<Heading, ProjectContext>, IHeadingDal
    {
        ProjectContext db = new ProjectContext();
        public List<Heading> Include(Expression<Func<Heading, bool>> filter = null)
        {
            using (var db=new ProjectContext())
            {

                return db.Headings.Include(x => x.Category).ToList();

            }
        }

       
    }
}
