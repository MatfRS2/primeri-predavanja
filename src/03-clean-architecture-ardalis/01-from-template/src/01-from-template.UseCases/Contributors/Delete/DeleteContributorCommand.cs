using Ardalis.Result;
using Ardalis.SharedKernel;

namespace _01_from_template.UseCases.Contributors.Delete;
public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
