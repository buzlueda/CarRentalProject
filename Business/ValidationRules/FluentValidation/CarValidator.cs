using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Description).NotEmpty().WithMessage("Car Name cannot be empty.");
            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage("Daily price cannot be set as 0");
        }
    }
}