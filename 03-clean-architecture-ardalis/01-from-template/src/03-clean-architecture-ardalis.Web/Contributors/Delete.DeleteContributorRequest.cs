namespace _03_clean_architecture_ardalis.Web.Contributors;

public record DeleteContributorRequest
{
  public const string Route = "/Contributors/{ContributorId:int}";
  public static string BuildRoute(int contributorId) => Route.Replace("{ContributorId:int}", contributorId.ToString());

  public int ContributorId { get; set; }
}
