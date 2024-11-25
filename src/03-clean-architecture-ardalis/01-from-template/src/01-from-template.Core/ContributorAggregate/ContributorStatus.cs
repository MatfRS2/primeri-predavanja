using Ardalis.SmartEnum;

namespace _01_from_template.Core.ContributorAggregate;
public class ContributorStatus : SmartEnum<ContributorStatus>
{
  public static readonly ContributorStatus CoreTeam = new(nameof(CoreTeam), 1);
  public static readonly ContributorStatus Community = new(nameof(Community), 2);
  public static readonly ContributorStatus NotSet = new(nameof(NotSet), 3);

  protected ContributorStatus(string name, int value) : base(name, value) { }
}

