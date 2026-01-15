using FastEndpoints;
using FluentValidation;

namespace _03_clean_architecture_ardalis.Web.Contributors;

/// <summary>
/// See: https://fast-endpoints.com/docs/validation
/// </summary>
public class GetContributorValidator : Validator<GetContributorByIdRequest>
{
  public GetContributorValidator()
  {
    RuleFor(x => x.ContributorId)
      .GreaterThan(0)
      .WithMessage($"Identifikator mora biti pozitivan" );
  }
}
