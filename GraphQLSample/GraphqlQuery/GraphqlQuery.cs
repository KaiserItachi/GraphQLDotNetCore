using GraphQL.Types;
using GraphQLSample.GraphqlTypes;
using System;

namespace GraphQLSample.GraphqlQuery
{
    public class GraphqlQuery : ObjectGraphType<object>
    {
        public GraphqlQuery(Repository repository)
        {
            Name = "Query";
            Description = "....";

            Field<ListGraphType<AccountType>>(
                "Account",
                resolve: context => repository.GetAccountDetails()
                );

            Field<ListGraphType<BranchType>>(
                "Branch",
                resolve: context => repository.GetBranchDetails()
                );

            Field<BranchType>(
               "GetBranchDetailById",
               arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "BranchId" }
                ),
               resolve: context => repository.GetBranchByBranchId(context.GetArgument<int>("BranchId"))
               );

            Field<AccountType>(
               "GetAccountById",
               arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "AccountId" }
                ),
               resolve: context => repository.GetAccountByAccountId(context.GetArgument<int>("AccountId"))
               );
        }
    }
}
