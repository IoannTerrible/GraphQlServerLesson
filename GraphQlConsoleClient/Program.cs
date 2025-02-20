namespace GraphQlConsoleClient;

internal class Program
{
	static async Task Main(string[] args)
	{
		Console.WriteLine("Hello, World!");
		var repository = new AppleGraphQlRepository();
		var a = await repository.GetAsync("AppleName",CancellationToken.None);
	}
}
