using _01_from_template.Web.ContributorEndpoints;

namespace _01_from_template.Web.Endpoints.ContributorEndpoints;
public class UpdateContributorResponse
{
  public UpdateContributorResponse(ContributorRecord contributor)
  {
    Contributor = contributor;
  }
  public ContributorRecord Contributor { get; set; }
}
