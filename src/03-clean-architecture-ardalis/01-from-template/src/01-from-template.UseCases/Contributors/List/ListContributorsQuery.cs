using Ardalis.Result;
using Ardalis.SharedKernel;

namespace _01_from_template.UseCases.Contributors.List;
public record ListContributorsQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<ContributorDTO>>>;
