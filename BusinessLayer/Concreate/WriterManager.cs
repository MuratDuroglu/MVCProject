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
    public class WriterManager : IWriterService
    {
        IWriterDal writerDal;

        public WriterManager(IWriterDal _writerDal)
        {
            writerDal = _writerDal;
        }
        public Writer GetById(int Id)
        {
           return writerDal.Get(x => x.WriterId == Id);
        }

        public List<Writer> GetList()
        {
            return writerDal.GetAll();
        }

        public void WriterAdd(Writer _writer)
        {
            writerDal.Add(_writer);
        }

        public void WriterDelete(Writer writer)
        {
            writerDal.Delete(writer);
        }

        public void WriterUpdate(Writer writer)
        {
            writerDal.Update(writer);
        }
    }
}
