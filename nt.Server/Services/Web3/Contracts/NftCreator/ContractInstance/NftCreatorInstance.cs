using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Nethereum.RPC;
using Newtonsoft.Json;
using nt.Shared.Constants;
namespace nt.Server.Services.WebThree.Contracts.NftCreator.ContractInstance
{
    public class NftCreatorInstance
    {
        public NftCreatorInstance()
        {
        }
       static string NftCreatorAbi = reader.ReadToEnd();
       static readonly StreamReader reader = File.OpenText(@"C:\mv\nt\nt.Shared\Constants\ContractConstants\NftCreator\Abi.json;");
    
    }

}
