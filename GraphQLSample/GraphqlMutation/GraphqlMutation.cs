using GraphQL.Types;
using GraphQLSample.GraphqlTypes;

namespace GraphQLSample.GraphqlMutation
{
    public class GraphqlMutation : ObjectGraphType<object>
    {
        public GraphqlMutation(Repository respository)
        {
            Name = "Mutaiton";
            Description = "Mutaitons are used to perform the Create Update and Delete operations.";

            Field<AccountType>(
                "CreateAccount",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<AccountInputType>> { Name = "Account" }
                ),
                resolve: context =>
                {
                    var account = context.GetArgument<Account>("Account");
                    return respository.AddNewAccount(account);
                });
        }
    }
}
