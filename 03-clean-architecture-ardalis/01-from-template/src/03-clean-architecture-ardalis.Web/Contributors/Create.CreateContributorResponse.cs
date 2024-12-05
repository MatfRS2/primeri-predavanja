namespace _03_clean_architecture_ardalis.Web.Contributors;

public class CreateContributorResponse(int id, string name)
{
  public int Id { get; set; } = id;
  public string Name { get; set; } = name;
}
