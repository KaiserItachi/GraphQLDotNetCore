using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLSample.GraphqlTypes
{
    public class Account
    {
        public int AccountId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Country { get; set; }

        public string Email { get; set; }

        public int HomeBranchId { get; set; }
    }
}
