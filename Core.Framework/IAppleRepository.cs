
namespace GraphQlProvider.Querries;

public interface IAppleRepository
{
	Task<IApple?> GetAsync(string aplleName, CancellationToken ct);

	Task<IEnumerable<IApple?>> GetAsync(CancellationToken ct);

}
