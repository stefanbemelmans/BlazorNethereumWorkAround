using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Nethereum.RPC;
using Newtonsoft.Json;
using nt.Shared.Constants;
using nt.Server.Services.WebThree.Instance;
using Microsoft.AspNetCore.Components;
using Nethereum.Contracts;

namespace nt.Server.Services.WebThree.Contracts.NftCreator.ContractInstance
{
    public class NftCreatorInstance
    {
        public NftCreatorInstance()
        {
            Contract NftCreatorContractInstance = Web3Instance._.Eth. 

        }
       static string NftCreatorAbi = reader.ReadToEnd();
       static readonly StreamReader reader = File.OpenText(@"C:\mv\nt\nt.Shared\Constants\ContractConstants\NftCreator\Abi.json;");
        [Inject]
        Web3Instance Web3Instance { get; set; }
    }

}
