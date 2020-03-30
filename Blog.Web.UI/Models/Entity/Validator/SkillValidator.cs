using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web.UI.Models.Entity.Validator
{
    public class SkillValidator:AbstractValidator<Skill>
    {
        public SkillValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Boş alan bırakmayınız");
        }
    }
}
