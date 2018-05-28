using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLSample.GraphqlTypes
{
    public class BranchType : ObjectGraphType<Branch>   
    {
        public BranchType(Repository repo)
        {
            Name = "Branch";
            Description = "Branch related information";

            Field(d => d.BranchId);
            Field(d => d.Address);
            Field(d => d.BranchCode);
            Field(d => d.Country);
            Field<ListGraphType<AccountType>>(
                "AccountDetails",
                resolve: context => repo.GetAccountByBranchId(context.Source.BranchId));
        }
    }
}
