using FluentValidation;
using Petek.BUmatik.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.ValidationRules.FluentValidation
{
    public class StudentValidator : AbstractValidator<Student>//Kim için yazıyorsak list içine onun modelini vermemiz lazım
    {
        public StudentValidator()
        {
            RuleFor(p => p.FullName).NotEmpty();
            RuleFor(p => p.FullName).MinimumLength(2);
            RuleFor(p => p.BandNumber).NotEmpty();
            RuleFor(p => p.RemainingMoney).GreaterThan(0);
            //RuleFor(p => p.RemainingMoney).GreaterThanOrEqualTo(10).When(p => p.SchoolId == 1);
            //RuleFor(p => p.FullName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");
        }

        //private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
