using Ardalis.Specification;

namespace _01_from_template.Core.ContributorAggregate.Specifications;
public class ContributorByIdSpec : Specification<Contributor>
{
  public ContributorByIdSpec(int contributorId)
  {
    Query
        .Where(contributor => contributor.Id == contributorId);
  }
}
