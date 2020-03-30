using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web.UI.Models.Entity.Validator
{
    public class ReferenceValidator:AbstractValidator<Reference>
    {
        public ReferenceValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Boş alan bırakmayınız");
            RuleFor(x => x.FullName).NotEmpty().WithMessage("Boş alan bırakmayınız");
            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("Boş alan bırakmayınız");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Boş alan bırakmayınız");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Doğru formatta email adresi giriniz");
        }
    }
}
