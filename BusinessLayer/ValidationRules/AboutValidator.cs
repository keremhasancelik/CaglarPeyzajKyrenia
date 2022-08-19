using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen Başlık alanını doldurunuz");
            RuleFor(x => x.Detail).NotEmpty().WithMessage("Lütfen açıklama alanını doldurunuz");
        }
    }
}
