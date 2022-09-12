using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class HeadingManager : IHeadingService
    {

        IHeadingDal _headingdal;
        public HeadingManager(IHeadingDal heading)
        {
            _headingdal = heading;
        }
        public void Add(Heading _heading)
        {
            _headingdal.Add(_heading);
        }

        public void CategoryUpdate(Heading _heading)
        {
            _headingdal.Update(_heading);
        }

        public void Delete(Heading _heading)
        {
            _headingdal.Delete(_heading);
        }

        public Heading Get(int _heading)
        {
            return _headingdal.Get(x => x.HeadingId == _heading);

        }

        public List<Heading> GetAll()
        {
            return _headingdal.GetAll();
        }

        public List<Heading> Include()
        {
            return _headingdal.Include();
        }
    }
}
