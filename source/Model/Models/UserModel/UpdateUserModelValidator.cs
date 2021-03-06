using DotNetCore.Validation;
using FluentValidation;

namespace DotNetCoreArchitecture.Model
{
    public sealed class UpdateUserModelValidator : Validator<UpdateUserModel>
    {
        public UpdateUserModelValidator()
        {
            RuleFor(x => x).NotNull();
            RuleFor(x => x.UserId).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(x => x.FullName).NotNull().NotEmpty();
            RuleFor(x => x.FullName.Name).NotNull().NotEmpty();
            RuleFor(x => x.FullName.Surname).NotNull().NotEmpty();
            RuleFor(x => x.Email).NotNull().NotEmpty();
        }
    }
}
