using GraphQlProvider.Querries;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.SystemTextJson;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using GraphQL.Client.Abstractions;
using System.Text.Json;

namespace GraphQlConsoleClient;

public class AppleGraphQlRepository : IAppleRepository
{
	private GraphQLHttpClient _graphQlClient;

	public AppleGraphQlRepository()
	{
		_graphQlClient = new GraphQLHttpClient(
		$"http://localhost:5876/graphql/", new SystemTextJsonSerializer());
	}

	public async Task<IApple?> GetAsync(string aplleName, CancellationToken ct)
	{
		var request = AppleRequests.GetOneApple;
		request.Variables = new
		{
			aplleName = aplleName
		};
		var responce = await _graphQlClient
			.SendQueryAsync<GetApple>(request, ct)
			.ConfigureAwait(false);

		return responce.Data.apple;
	}

	public async Task<IEnumerable<IApple?>> GetAsync(CancellationToken ct)
	{
		throw new NotImplementedException();
	}
}
