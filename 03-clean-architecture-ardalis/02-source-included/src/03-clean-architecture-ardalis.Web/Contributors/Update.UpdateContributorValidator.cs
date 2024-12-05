using _03_clean_architecture_ardalis.Infrastructure.Data.Config;
using FastEndpoints;
using FluentValidation;

namespace _03_clean_architecture_ardalis.Web.Contributors;

/// <summary>
/// See: https://fast-endpoints.com/docs/validation
/// </summary>
public class UpdateContributorValidator : Validator<UpdateContributorRequest>
{
  public UpdateContributorValidator()
  {
    RuleFor(x => x.Name)
      .NotEmpty()
      .WithMessage("Name is required.")
      .MinimumLength(2)
      .MaximumLength(DataSchemaConstants.DEFAULT_NAME_LENGTH);
    RuleFor(x => x.ContributorId)
      .Must((args, contributorId) => args.Id == contributorId)
      .WithMessage("Route and body Ids must match; cannot update Id of an existing resource.");
  }
}
