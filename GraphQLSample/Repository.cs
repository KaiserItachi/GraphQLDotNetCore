using System;
using System.Collections.Generic;
using System.Linq;
using GraphQLSample.GraphqlTypes;

namespace GraphQLSample
{
    public class Repository
    {
        private List<Account> _accountList = new List<Account>();

        private List<Branch> _branchList = new List<Branch>();

        public Repository()
        {
            _accountList.Add(new Account
            {
                AccountId = 1,
                Address = "Elcot Building, Sholinganallur",
                Country = "India",
                Email = "Mohan@xyz.com",
                Name = "Mohan",
                HomeBranchId = 1
            });

            _accountList.Add(new Account
            {
                AccountId = 2,
                Address = "Downtown Tokyo",
                Country = "Japan",
                Email = "June@abc.com",
                Name = "June",
                HomeBranchId = 1
            });

            _branchList.Add(new Branch
            {
                BranchId = 1,
                BranchCode = "CBS52125",
                Country = "Australia",
                Address = "48 Martin Street",
                AccountList = _accountList
            });
        }

        public List<Account> GetAccountDetails()
        {
            return _accountList;
        }

        public List<Branch> GetBranchDetails()
        {
            return _branchList;
        }

        public List<Account> GetAccountByBranchId(int BranchId)
        {
            return _accountList.Where(x => x.HomeBranchId == BranchId).ToList();
        }

        public Branch GetBranchByBranchId(int BranchId)
        {
            return _branchList.FirstOrDefault(x => x.BranchId == BranchId);
        }

        public Account GetAccountByAccountId(int AccountId)
        {
            return _accountList.FirstOrDefault(x => x.AccountId == AccountId);
        }

        public Account AddNewAccount(Account account)
        {
            _accountList.Add(account);
            return account;
        }
    }
}
