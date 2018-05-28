using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLSample.GraphqlTypes
{
    public class AccountType : ObjectGraphType<Account>
    {
        public AccountType(Repository repo)
        {
            Name = "Account";
            Description = "Account information of a person";

            Field(d => d.AccountId);
            Field(d => d.Address);
            Field(d => d.Name);
            Field(d => d.Country);
            Field(d => d.Email);
            Field(d => d.HomeBranchId);
            Field<BranchType>("BranchDetail", resolve: context => repo.GetBranchByBranchId(context.Source.HomeBranchId));
        }
    }
}
