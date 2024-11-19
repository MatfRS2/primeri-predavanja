using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Project.UseCases.Contributors.List;
public record ListContributorsQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<ContributorDTO>>>;
