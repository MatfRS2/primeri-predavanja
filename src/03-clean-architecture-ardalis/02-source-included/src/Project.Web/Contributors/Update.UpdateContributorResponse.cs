using Project.Web.ContributorEndpoints;

namespace Project.Web.Endpoints.ContributorEndpoints;
public class UpdateContributorResponse
{
  public UpdateContributorResponse(ContributorRecord contributor)
  {
    Contributor = contributor;
  }
  public ContributorRecord Contributor { get; set; }
}
