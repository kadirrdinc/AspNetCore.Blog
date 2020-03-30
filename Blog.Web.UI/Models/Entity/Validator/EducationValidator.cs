using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web.UI.Models.Entity.Validator
{
    public class EducationValidator : AbstractValidator<Education>
    {
        public EducationValidator()
        {
            RuleFor(x => x.SchoolName).NotEmpty().WithMessage("Boş alan bırakmayınız");
            RuleFor(x => x.SectionName).NotEmpty().WithMessage("Boş alan bırakmayınız");
            RuleFor(x => x.DateOfStart).NotEmpty().WithMessage("Boş alan bırakmayınız");
            //RuleFor(x => x.DateOfFinish).NotEmpty().WithMessage("Boş alan bırakmayınız");

        }
    }
}
