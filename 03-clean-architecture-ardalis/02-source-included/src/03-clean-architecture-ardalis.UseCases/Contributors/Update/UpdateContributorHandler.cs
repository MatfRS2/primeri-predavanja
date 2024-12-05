using _03_clean_architecture_ardalis.Core.ContributorAggregate;

namespace _03_clean_architecture_ardalis.UseCases.Contributors.Update;

public class UpdateContributorHandler(IRepository<Contributor> _repository)
  : ICommandHandler<UpdateContributorCommand, Result<ContributorDTO>>
{
  public async Task<Result<ContributorDTO>> Handle(UpdateContributorCommand request, CancellationToken cancellationToken)
  {
    var existingContributor = await _repository.GetByIdAsync(request.ContributorId, cancellationToken);
    if (existingContributor == null)
    {
      return Result.NotFound();
    }

    existingContributor.UpdateName(request.NewName!);

    await _repository.UpdateAsync(existingContributor, cancellationToken);

    return new ContributorDTO(existingContributor.Id,
      existingContributor.Name, existingContributor.PhoneNumber?.Number ?? "");
  }
}
