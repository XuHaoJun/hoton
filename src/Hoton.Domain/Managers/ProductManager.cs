using System.Text.Json.Nodes;
using GraphQL;
using GraphQL.Client.Abstractions;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.SystemTextJson;
using GraphQLParser.AST;

namespace Hoton.Domain.Managers;

public class ProductManager
{
    private readonly IGraphQLClient _graphQLClient;

    public ProductManager()
    {
        _graphQLClient = new GraphQLHttpClient("http://localhost:3280/graphql", new SystemTextJsonSerializer());
    }

    public async Task<Dictionary<string, int>> ProcessDynamicQuery(string graphQLQueryString)
    {
        // Parse the GraphQL query
        var parsedQuery = ParseGraphQLQuery(graphQLQueryString);

        // Extract where clause and other parameters
        var whereClause = ExtractWhereClause(parsedQuery);
        var selectionSet = ExtractSelectionSet(parsedQuery);

        // Initialize category counter
        var categoryCounter = new Dictionary<string, int>();
        int skip = 0;
        const int batchSize = 10000;

        while (true)
        {
            // Dynamically construct the query with pagination
            var dynamicQuery = ConstructDynamicQuery(whereClause, selectionSet, skip, batchSize);

            // Execute the query
            var result = await ExecuteGraphQLQuery(dynamicQuery);

            // Break if no more results
            if (result == null || !result.Any())
                break;

            // Process results
            ProcessQueryResults(result, categoryCounter, selectionSet);

            skip += batchSize;
        }

        return categoryCounter;
    }

    private GraphQLDocument ParseGraphQLQuery(string queryString)
    {
        try
        {
            return GraphQLParser.Parser.Parse(queryString);
        }
        catch (Exception ex)
        {
            throw new Exception($"Error parsing GraphQL query: {ex.Message}", ex);
        }
    }

    private JsonNode ExtractWhereClause(GraphQLDocument parsedQuery)
    {
        // Find the first operation definition
        var operationDefinition = parsedQuery.Definitions.OfType<GraphQLOperationDefinition>().FirstOrDefault();

        if (operationDefinition == null)
            throw new Exception("No operation definition found in the query");

        // Find the first field with selection set
        var field = operationDefinition.SelectionSet.Selections.OfType<GraphQLField>().FirstOrDefault();

        if (field == null)
            throw new Exception("No field found in the query");

        // Extract where argument
        var whereArgument = field.Arguments.FirstOrDefault(arg =>
            arg.Name.Value.ToString().Equals("where", StringComparison.OrdinalIgnoreCase)
        );

        if (whereArgument == null)
            return null;

        // Convert to JSON
        var whereJson = ConvertArgumentValueToJson(whereArgument.Value);
        return whereJson;
    }

    private List<string> ExtractSelectionSet(GraphQLDocument parsedQuery)
    {
        // Find the first operation definition
        var operationDefinition = parsedQuery.Definitions.OfType<GraphQLOperationDefinition>().FirstOrDefault();

        if (operationDefinition == null)
            throw new Exception("No operation definition found in the query");

        // Find the first field with selection set
        var field = operationDefinition.SelectionSet.Selections.OfType<GraphQLField>().FirstOrDefault();

        if (field == null)
            throw new Exception("No field found in the query");

        // Extract selection set
        return field.SelectionSet.Selections.OfType<GraphQLField>().Select(f => f.Name.Value.ToString()).ToList();
    }

    private JsonNode ConvertArgumentValueToJson(GraphQLValue value)
    {
        switch (value)
        {
            case GraphQLObjectValue objectValue:
                var jsonObject = new JsonObject();
                foreach (var field in objectValue.Fields)
                {
                    jsonObject[field.Name.Value.ToString()] = ConvertArgumentValueToJson(field.Value);
                }
                return jsonObject;

            case GraphQLListValue listValue:
                var jsonArray = new JsonArray();
                foreach (var item in listValue.Values)
                {
                    jsonArray.Add(ConvertArgumentValueToJson(item));
                }
                return jsonArray;

            case GraphQLStringValue stringValue:
                return stringValue.Value.ToString();

            case GraphQLIntValue intValue:
                return JsonValue.Create(intValue.Value);

            case GraphQLBooleanValue booleanValue:
                return JsonValue.Create(booleanValue.Value);

            default:
                return null;
        }
    }

    private string ConstructDynamicQuery(JsonNode whereClause, List<string> selectionSet, int skip, int take)
    {
        // Construct a dynamic GraphQL query based on the original query's structure
        var queryBuilder = new System.Text.StringBuilder();
        queryBuilder.Append("query DynamicProductSearch {");
        queryBuilder.Append("productProduct(");

        // Add where clause if exists
        if (whereClause != null)
        {
            queryBuilder.Append($"where: {whereClause}, ");
        }

        // Add pagination
        queryBuilder.Append($"skip: {skip}, take: {take}) {{");

        // Add selection set dynamically
        foreach (var field in selectionSet)
        {
            queryBuilder.Append($"{field} ");
        }

        queryBuilder.Append("}}");

        return queryBuilder.ToString();
    }

    private async Task<JsonArray> ExecuteGraphQLQuery(string dynamicQuery)
    {
        // Implement actual GraphQL query execution
        // This is a placeholder and should be replaced with actual GraphQL client execution
        var greq = new GraphQLRequest
        {
            Query = """
                query MyQuery {
                    productProduct {
                        name
                    }
                }
                """,
            OperationName = "MyQuery",
        };
        var result = await _graphQLClient.SendQueryAsync<JsonNode>(greq);

        // Extract and return the product list
        return result.Data["productProduct"].AsArray();
    }

    private void ProcessQueryResults(
        JsonArray results,
        Dictionary<string, int> categoryCounter,
        List<string> selectionSet
    )
    {
        foreach (var result in results)
        {
            // Dynamic processing based on selection set
            if (selectionSet.Contains("productProductCategories"))
            {
                var categories = result["productProductCategories"].AsArray();
                foreach (var category in categories)
                {
                    var categoryName = category["category"].GetValue<string>();

                    if (categoryCounter.ContainsKey(categoryName))
                        categoryCounter[categoryName]++;
                    else
                        categoryCounter[categoryName] = 1;
                }
            }
        }
    }

    // Method to print category counts
    public void PrintCategoryCounts(Dictionary<string, int> categoryCounts)
    {
        Console.WriteLine("Category Counts:");
        foreach (var category in categoryCounts.OrderByDescending(x => x.Value))
        {
            Console.WriteLine($"{category.Key}: {category.Value}");
        }
    }
}
