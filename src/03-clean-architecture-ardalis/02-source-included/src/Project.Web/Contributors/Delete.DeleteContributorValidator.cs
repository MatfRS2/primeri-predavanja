﻿using FastEndpoints;
using FluentValidation;

namespace Project.Web.Endpoints.ContributorEndpoints;
/// <summary>
/// See: https://fast-endpoints.com/docs/validation
/// </summary>
public class DeleteContributorValidator : Validator<DeleteContributorRequest>
{
  public DeleteContributorValidator()
  {
    RuleFor(x => x.ContributorId)
      .GreaterThan(0);
  }
}
