namespace _03_clean_architecture_ardalis.UnitTests.Core.ContributorAggregate;

public class ContributorConstructor
{
  private readonly string _testName = "test name";
  private Contributor? _testContributor;

  private Contributor CreateContributor()
  {
    return new Contributor(_testName);
  }

  
  [Fact]
  public void ShoudNameBeSameAsInCreation()
  {
    // arrange - act
    _testContributor = CreateContributor();
    // assert
    Assert.Equal(_testName, _testContributor.Name);
  }

  [Fact]
  public void SholudPhoneNameBeNotNull()
  {
    // arrange - act
    _testContributor = CreateContributor();
    // assert
    Assert.NotNull(_testContributor.PhoneNumber);
  }
  }

