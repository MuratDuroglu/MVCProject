﻿using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public interface IWriterService
    {

        List<Writer> GetList();

        void WriterAdd(Writer _writer);

        void WriterDelete(Writer writer);

        void WriterUpdate(Writer writer);

        Writer GetById(int Id);









    }
}
