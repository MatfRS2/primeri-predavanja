using Ardalis.Result;
using Ardalis.SharedKernel;

namespace _01_from_template.UseCases.Contributors.Update;
public record UpdateContributorCommand(int ContributorId, string NewName) : ICommand<Result<ContributorDTO>>;
