using FluentValidation;

namespace BlazorSampleCrud.App.Shread.Features.ManageCustomer
{
    public class CustomerDtoValidator : AbstractValidator<CustomerDto>
    {
        public CustomerDtoValidator()
        {
            RuleFor(c => c.FirstName)
                .NotEmpty().WithMessage("The Field Related to the Customer's Firstname Must be Filled")
                .MaximumLength(80).WithMessage("The maximum allowed length is 80 characters")
                .MinimumLength(2).WithMessage("The minimum allowed length is 2 characters");

            RuleFor(c => c.LastName)
                .NotEmpty().WithMessage("The Field Related to the Customer's Lastname Must be Filled")
                .MaximumLength(80).WithMessage("The maximum allowed length is 80 characters")
                .MinimumLength(2).WithMessage("The minimum allowed length is 2 characters");

            RuleFor(c => c.DateOfBirth)
                .NotEmpty().WithMessage("The Field Related to the Customer's Date Of Birth Must be Filled");

            RuleFor(c => c.PhoneNumber)
                .NotEmpty().WithMessage("The Field Related to the Customer's Phone Number Must be Filled")
                .MaximumLength(11).MinimumLength(11).WithMessage("The Allowed Length For the Phone Number is 11 Characters");
                

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("The Field Related to the Customer's Email Must be Filled")
                .EmailAddress().WithMessage("The Email Address Entered is Not Valid")
                .MaximumLength(100).WithMessage("The Maximum Allowed Length is 100 Characters");

            RuleFor(c => c.BankAccountNumber)
                .NotEmpty().WithMessage("The Field Related to the Customer's Bank Account Number Must be Filled")
                .MaximumLength(11).WithMessage("The Maximum Allowed Length is 11 Characters")
                .MinimumLength(6).WithMessage("The Minimum Allowed Length is 6 Characters")
                .Matches(@"^[0-9]+$").WithMessage("Phone Number Is Invalid");

        }
    }
}
