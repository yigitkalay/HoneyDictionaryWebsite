using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Adımını Boş Geçemezsiniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Açıklamasını Boş Geçemezsiniz.");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Kullanıcı Adı Adımını Boş Geçemezsiniz.");
            RuleFor(x => x.Message).MaximumLength(20).WithMessage("Mesaj Adımını Boş Geçemezsiniz.");

        }
    }
}
