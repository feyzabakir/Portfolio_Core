using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class PortfolioValidator: AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Project name cannot be blank");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Image field cannot be left blank.");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Image 2 field cannot be left blank");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Price field cannot be empty");
            RuleFor(x => x.Values).NotEmpty().WithMessage("Completion rate field cannot be left blank");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Project name must be at least 5 characters");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("The project name must be a maximum of 100 characters.");
        }
    }
}
