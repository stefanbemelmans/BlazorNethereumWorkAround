namespace nt.Client.Nft.Contracts
{   // [Function("name", "return type")]
    using Nethereum.ABI.FunctionEncoding.Attributes;
    using Nethereum.Contracts;
    using System.Numerics;

    [FunctionOutput] // This Works
    public class GetTotalNftTypesFunctionOutputDTO : IFunctionOutputDTO
    {
        [Parameter("uint", "totalNFTs", 1)]
        public int TotalNftTypes { get; set; }
    }

    [Function("getNFTData")] // This works
    public class GetNftByIdFunction : FunctionMessage
    {
        [Parameter("uint", "id", 1)]
        public int NftId { get; set; }
    }

    [FunctionOutput]  // This works
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

    // Create a new NFT Template 
    // This Works
    [Function("AddNFTTemplate")]
    public class AddNewNftTemplateFunction : FunctionMessage
    {
        [Parameter("string", "name", 1)]
        public string NewNftTemplateName { get; set; }

        [Parameter("string", "symbol", 2)]
        public string NewNftTemplateSymbol { get; set; }

        [Parameter("uint", "mintlimit", 3)]
        public BigInteger NewNftTemplateMintLimit { get; set; }

        [Parameter("uint", "attachedTokens", 4)]

        public BigInteger NewNftTemplateAttachedTokens { get; set; }

    }

    [Function("mintNFT")]
    // Mints the selected NFT template
    // Triggers Herc1155 Transfer Single Event
    public class MintNftFunction : FunctionMessage 
    {
        [Parameter("uint", "type", 1)]
        public int Type { get; set; }

        [Parameter("string", "data", 2)]
        public string ImmutableData { get; set; }

        [Parameter("string", "mutabledata", 3)]
        public string MutableData { get; set; }

    }
}
