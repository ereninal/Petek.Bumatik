using FluentValidation;
using Petek.BUmatik.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.ValidationRules.FluentValidation
{
    public class SchoolValidator: AbstractValidator<School>
    {
        public SchoolValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MinimumLength(2);
            RuleFor(p => p.Address).NotEmpty();
            RuleFor(p => p.Address).MinimumLength(2);
        }
    }
}
