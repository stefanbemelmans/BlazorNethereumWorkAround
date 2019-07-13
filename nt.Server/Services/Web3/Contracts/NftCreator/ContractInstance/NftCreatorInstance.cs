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
        public NftCreatorInstance(Web3Instance aWeb3Instance)
        {
            Web3Instance = aWeb3Instance;
            Contract NftCreatorContractInstance = Web3Instance.Web3Instantiated.Eth.GetContract(NftCreatorAbi, NftCreatorAddresses.NftCreatorRinkebyAddress); 

        }
        string NftCreatorAbi = File.ReadAllText(@"C:\mv\nt\nt.Shared\Constants\ContractConstants\NftCreator\Abi.json;");
       
        Web3Instance Web3Instance { get; set; }
    }

}
