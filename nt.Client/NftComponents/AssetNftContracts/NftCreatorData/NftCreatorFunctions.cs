using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nt.Client.NftComponents.Contracts
{   // [Function("name", "return type")]
    // [Parameter("type", "paramName", order)]

    [Function("getNFTData")]
    public class GetNftByIdFunction : FunctionMessage
    {
        [Parameter("uint", "id", 1)]
        public int NftId { get; set; }
    }

    [FunctionOutput]
    public class GetNftByIdFunctionOutputDTO : IFunctionOutputDTO
    {
        [Parameter("string", "tokentype.name", 1)]
        public string TokenName { get; set; }

        [Parameter("string", "tokentype.symbol", 2)]
        public string TokenSymbol { get; set; }

        [Parameter("uint", "tokentype.mintlimit", 3)]
        public int TokenMintLimit { get; set; }

        [Parameter("uint", "tokentype.attachedTokens", 4)]
        public int TokenAttachedTokens { get; set; }

    }

    [Function("AddNewNft")]
    public class AddNewNftTemplateFunction : FunctionMessage
    {
        [Parameter("string", "_name", 1)]
        public string NewNftTemplateName { get; set; }

        [Parameter("string", "_symbol", 2)]
        public string NewNftTemplateSymbol { get; set; }

        [Parameter("uint", "_mintlimit", 3)]
        public int NewNftTemplateMintLimit { get; set; }

        [Parameter("uint", "_attachedtokens", 4)]

        public int NewNftTemplateAttachedTokens { get; set; }

    }

    [Function("mintNFT")]
    public class MintNftFunction : FunctionMessage 
    {
        [Parameter("uint", "_type", 1)]
        public int Type { get; set; }

        [Parameter("string", "data", 2)]
        public string ImmutableData { get; set; }

        [Parameter("string", "mutabledata", 3)]
        public string MutableData { get; set; }

    }
}
