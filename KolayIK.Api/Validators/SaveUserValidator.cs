using FluentValidation;
using KolayIK.Core.DTO;
using KolayIK.Core.Modal;

namespace KolayIK.Api.Validators
{
    public class SaveUserValidator: AbstractValidator<SaveUserDTO>
    {
        public SaveUserValidator()
        {
            RuleFor(x => x.FirstName)
            .NotEmpty().WithMessage("First name is required.")
            .MaximumLength(50).WithMessage("First name cannot be longer than 50 characters.");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Last name is required.")
                .MaximumLength(50).WithMessage("Last name cannot be longer than 50 characters.");

            RuleFor(x => x.GenderID)
                .NotEmpty().WithMessage("Gender is required.")
                .GreaterThan(0).WithMessage("Gender must be a valid ID.");

            RuleFor(x => x.UserName)
                .NotEmpty().WithMessage("User name is required.")
                .MaximumLength(50).WithMessage("User name cannot be longer than 50 characters.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters long.")
                .Matches(@"[A-Z]").WithMessage("Password must contain at least one uppercase letter.")
                .Matches(@"\d").WithMessage("Password must contain at least one number.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("A valid email address is required.");

            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("Phone number is required.")
                .Matches(@"^\+?\d{10,15}$").WithMessage("A valid phone number is required.");

            RuleFor(x => x.BirthDate)
                .NotEmpty().WithMessage("Birth date is required.")
                .LessThan(DateTime.Now).WithMessage("Birth date must be in the past.");


            RuleFor(x => x.PositionID)
                .NotEmpty().WithMessage("Position is required.")
                .GreaterThan(0).WithMessage("Position must be a valid ID.");

            RuleFor(x => x.HireDate)
                .NotEmpty().WithMessage("Hire date is required.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Hire date cannot be in the future.");

            RuleFor(x => x.Salary)
                .NotEmpty().WithMessage("Salary is required.")
                .GreaterThanOrEqualTo(0).WithMessage("Salary must be a positive number.");

        }
    }
}
