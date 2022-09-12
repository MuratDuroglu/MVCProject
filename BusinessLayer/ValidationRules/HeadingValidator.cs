using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
  public  class HeadingValidator:AbstractValidator<Heading>
    {

        public HeadingValidator()
        {
            RuleFor(x => x.HeadingName).NotEmpty().WithMessage("Başlık adını boş geçemezsiniz");
            RuleFor(x => x.HeadingDate).NotEmpty().WithMessage("Tarih alanını boş geçemezsiniz");


        }
    }
}
