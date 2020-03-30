using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web.UI.Models.Entity.Validator
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Boş alan bırakmayınız");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Boş alan bırakmayınız");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Boş alan bırakmayınız");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Boş alan bırakmayınız");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Doğru formatta mail adresi giriniz");
        }
    }
}
