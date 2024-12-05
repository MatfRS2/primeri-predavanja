using _03_clean_architecture_ardalis.UseCases.Contributors;
using _03_clean_architecture_ardalis.UseCases.Contributors.List;

namespace _03_clean_architecture_ardalis.Infrastructure.Data.Queries;

public class FakeListContributorsQueryService : IListContributorsQueryService
{
  public Task<IEnumerable<ContributorDTO>> ListAsync()
  {
    IEnumerable<ContributorDTO> result =
        [new ContributorDTO(1, "Fake Contributor 1", ""),
        new ContributorDTO(2, "Fake Contributor 2", "")];

    return Task.FromResult(result);
  }
}
