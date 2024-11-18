using Ardalis.Result;
using Ardalis.SharedKernel;

namespace _01_from_template.UseCases.Contributors.Get;
public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
