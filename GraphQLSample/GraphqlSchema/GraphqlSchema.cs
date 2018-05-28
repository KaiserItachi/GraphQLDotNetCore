using GraphQL;
using GraphQL.Types;

namespace GraphQLSample.GraphqlSchema
{
    public class GraphqlSchema : Schema
    {
        public GraphqlSchema(IDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<GraphqlQuery.GraphqlQuery>();
            Mutation = resolver.Resolve<GraphqlMutation.GraphqlMutation>();
        }
    }
}
