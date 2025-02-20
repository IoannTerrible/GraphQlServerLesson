using GraphQlProvider.Querries;

namespace SampleDatabasePrj;

public class AppleRepository : IAppleRepository
{
	public async Task<IApple?> GetAsync(string aplleName, CancellationToken ct)
	{
		return new AppleImp();
	}

	public async Task<IEnumerable<IApple?>> GetAsync(CancellationToken ct)
	{
		return [new AppleImp(), new AppleImp(), new AppleImp()];
	}
}
