using GraphQL;

namespace GraphQlConsoleClient;

public static class AppleRequests
{
	public static GraphQLRequest GetAllCatalogs = new() //
	{
		Query = @"query AllApple {
				  allApples {
				    appleGuid
				  }
				}"
	};

	public static GraphQLRequest GetOneApple = new() //
	{
		Query = @"query OneApple($aplleName : String!) {
					  apple(aplleName: $aplleName) {
					    appleGuid
					  }
					}"
	};
}
