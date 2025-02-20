namespace GraphQlProvider.Querries;

[ExtendObjectType<BaseQueries>]
public class AppleQueries
{
	private readonly IAppleRepository _repo;

	public AppleQueries(IAppleRepository repository)
	{
		_repo = repository;
	}

	public Task<IApple?> GetAppleAsync(
		string aplleName,
		CancellationToken ct) => _repo.GetAsync(aplleName, ct);


	public Task<IEnumerable<IApple?>> GetAllApplesAsync(
			CancellationToken ct) => _repo.GetAsync(ct);
}

