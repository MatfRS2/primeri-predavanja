using Ardalis.Specification;

namespace Project.Core.ContributorAggregate.Specifications;
public class ContributorByIdSpec : Specification<Contributor>
{
  public ContributorByIdSpec(int contributorId)
  {
    Query
        .Where(contributor => contributor.Id == contributorId);
  }
}
