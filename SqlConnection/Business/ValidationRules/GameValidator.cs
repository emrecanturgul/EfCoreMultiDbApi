using FluentValidation;
using SqlWebApi.Models;

namespace SqlWebApi.Business.ValidationRules
{
    public class GameValidator : AbstractValidator<Game> 
    {
        public GameValidator()
        {
            RuleFor(x => x.GameName)
            .NotEmpty().WithMessage("Game name is required.")
            .MaximumLength(100).WithMessage("Game name cannot exceed 100 characters.");

        }
       
    }
}
