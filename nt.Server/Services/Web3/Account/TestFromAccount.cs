using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using nt.Shared.Constants.AccountAddresses;


namespace nt.Server.Services.WebThree.TestAccount
{
    public class TestFromAccount
    {
        public TestFromAccount()
        {
         EthFromAccount = new Account(TestEthAccounts.TestEthPrivateKey);
        }

       public static Account EthFromAccount { get; set; }
    }

}
