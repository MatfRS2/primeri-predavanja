namespace _03_clean_architecture_ardalis.Core.ContributorAggregate.Specifications;

public class ContributorByIdSpec : Specification<Contributor>
{
  public ContributorByIdSpec(int contributorId) =>
    Query
        .Where(contributor => contributor.Id == contributorId);
}
