using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Adı Alanını Boş Geçemezsiniz.");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Soyad Alanını Boş Geçemezsiniz.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında Alanı Boş Geçemezsiniz.");
            RuleFor(x => x.WriterAbout).MinimumLength(3).WithMessage("En az 3 karakterli giriş yapın");
            RuleFor(x => x.WriterAbout).MaximumLength(100).WithMessage("En fazla 100 karakterli giriş yapın");

        }
    }
}
