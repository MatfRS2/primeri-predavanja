﻿using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Project.UseCases.Contributors.Get;
public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
