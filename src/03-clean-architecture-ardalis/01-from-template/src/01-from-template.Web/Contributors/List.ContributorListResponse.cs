using _01_from_template.Web.ContributorEndpoints;

namespace _01_from_template.Web.Endpoints.ContributorEndpoints;
public class ContributorListResponse
{
  public List<ContributorRecord> Contributors { get; set; } = new();
}
