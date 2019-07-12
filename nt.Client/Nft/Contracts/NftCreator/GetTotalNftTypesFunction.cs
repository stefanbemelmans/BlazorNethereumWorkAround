namespace nt.Client.Nft.Contracts
{   // [Function("name", "return type")]
    using Nethereum.ABI.FunctionEncoding.Attributes;
    using Nethereum.Contracts;

    // [Parameter("type", "paramName", order)]

    [Function(name: "totalNFTs", returnType: "uint")]
    public class GetTotalNftTypesFunction : FunctionMessage
    {

    }
}
