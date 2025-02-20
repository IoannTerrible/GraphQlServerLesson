using GraphQlProvider.Querries;

namespace SampleDatabasePrj;

public sealed class AppleImp : IApple
{
	public Guid AppleGuid { get; set; } = Guid.NewGuid();

	public static object SomeObject => new
	{
		Timestamp = DateTime.Now,
		RandomNumber = new Random().Next(1, 1000),
		Info = "Just a random data bag"
	};
}
