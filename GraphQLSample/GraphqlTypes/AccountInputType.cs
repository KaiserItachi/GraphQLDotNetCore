using GraphQL.Types;

namespace GraphQLSample.GraphqlTypes
{
    public class AccountInputType : InputObjectGraphType
    {
        public AccountInputType()
        {
            Name = "AccountInput";

            Field<NonNullGraphType<IntGraphType>>("AccountId");
            Field<StringGraphType>("Name");
            Field<StringGraphType>("Address");
            Field<StringGraphType>("Country");
            Field<StringGraphType>("Email");
            Field<IntGraphType>("HomeBranchId");
        }
    }
}
