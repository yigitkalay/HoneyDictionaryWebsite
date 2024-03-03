using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class HeadingValidator:AbstractValidator<Heading>
    {
        public HeadingValidator()
        {
            RuleFor(x => x.HeadingName).NotEmpty().WithMessage("Başlık Alanını Boş Geçemezsiniz.");
            RuleFor(x => x.HeadingName).MinimumLength(3).WithMessage("En az 3 karakterli giriş yapın");
            RuleFor(x => x.HeadingName).MaximumLength(100).WithMessage("En fazla 100 karakterli giriş yapın");

        }
    }
}
