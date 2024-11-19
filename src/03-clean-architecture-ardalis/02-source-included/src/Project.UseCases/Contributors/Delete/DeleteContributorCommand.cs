using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Project.UseCases.Contributors.Delete;
public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
