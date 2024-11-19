using Project.Web.ContributorEndpoints;

namespace Project.Web.Endpoints.ContributorEndpoints;
public class ContributorListResponse
{
  public List<ContributorRecord> Contributors { get; set; } = new();
}
