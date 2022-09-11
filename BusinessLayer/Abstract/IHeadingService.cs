using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        
        void Add(Heading _heading);

        void Delete(Heading _heading);


        Heading Get(int _heading);


        List<Heading> GetAll();

        void CategoryUpdate(Heading _heading);
    }
}
