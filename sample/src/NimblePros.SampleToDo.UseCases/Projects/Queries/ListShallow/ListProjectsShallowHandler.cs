namespace NimblePros.SampleToDo.UseCases.Projects.Queries.ListShallow;

public class ListProjectsShallowHandler(IListProjectsShallowQueryService query)
  : IQueryHandler<ListProjectsShallowQuery, Result<IEnumerable<ProjectDTO>>>
{
  private readonly IListProjectsShallowQueryService _query = query;

  public async Task<Result<IEnumerable<ProjectDTO>>> Handle(ListProjectsShallowQuery request, CancellationToken cancellationToken)
  {
    var result = await _query.ListAsync();

    return Result.Success(result);
  }
}
