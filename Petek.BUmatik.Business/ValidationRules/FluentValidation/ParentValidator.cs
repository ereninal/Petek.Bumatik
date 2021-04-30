using FluentValidation;
using Petek.BUmatik.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.ValidationRules.FluentValidation
{
    public class ParentValidator : AbstractValidator<Parent>
    {
        public ParentValidator()
        {
            RuleFor(p => p.FullName).NotEmpty();
            RuleFor(p => p.FullName).MinimumLength(2);
            RuleFor(p => p.Email).NotEmpty();
            RuleFor(p => p.PasswordSalt).NotEmpty();
            RuleFor(p => p.PasswordHash).NotEmpty();
        }
    }
}
