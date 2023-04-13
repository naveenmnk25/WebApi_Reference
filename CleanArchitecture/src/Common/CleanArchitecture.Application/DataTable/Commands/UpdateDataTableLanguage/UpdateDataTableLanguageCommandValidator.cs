using FluentValidation;

namespace CleanArchitecture.Application.DataTable.Commands.UpdateDataTableLanguage
{
    public class UpdateDataTableLanguageCommandValidator : AbstractValidator<UpdateDataTableLanguageCommand>
    {
        public UpdateDataTableLanguageCommandValidator()
        {
            //RuleFor(x=>x.TranslationId).NotNull().NotEmpty().WithMessage("TranslationId is required.");
        }
    }
}
