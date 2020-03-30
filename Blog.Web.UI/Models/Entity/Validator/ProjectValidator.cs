using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web.UI.Models.Entity.Validator
{
    public class ProjectValidator:AbstractValidator<Project>
    {
        public ProjectValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Boş alan bırakmayınız");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Boş alan bırakmayınız");
            RuleFor(x => x.DateOfFinish).NotEmpty().WithMessage("Boş alan bırakmayınız");
            RuleFor(x => x.LinkToAddress).NotEmpty().WithMessage("Boş alan bırakmayınız");
        }
    }
}
