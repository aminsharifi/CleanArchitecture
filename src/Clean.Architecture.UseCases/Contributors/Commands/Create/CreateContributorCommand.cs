namespace Clean.Architecture.UseCases.Contributors.Commands.Create;

/// <summary>
/// Create a new Contributor.
/// </summary>
/// <param name="Name"></param>
public record CreateContributorCommand(string Name, string? PhoneNumber) : Ardalis.SharedKernel.ICommand<Result<int>>;
