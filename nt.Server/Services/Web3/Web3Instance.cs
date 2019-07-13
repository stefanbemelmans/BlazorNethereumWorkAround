﻿using Nethereum.Web3;
using nt.Shared.Constants.WebThree;
using nt.Server.Services.WebThree.TestAccount;

namespace nt.Server.Services.WebThree.Instance
{
    public class Web3Instance
    {
        public Web3Instance()
        {
            _ = new Web3(TestFromAccount.EthFromAccount, Web3Endpoints.RinkebyEndpoint);
        }

    }
}
