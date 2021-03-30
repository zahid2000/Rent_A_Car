using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Description).MinimumLength(2);
            RuleFor(c => c.DailyPrice).GreaterThan(1200);
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.ModelYear).GreaterThan(2010).WithMessage("arabanin yili 2010-dan boyuk olmali");

        }
    }
}
