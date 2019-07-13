namespace nt.Client.Server.Services.WebThree.Contracts
{   // [Function("name", "return type")]
    using Nethereum.ABI.FunctionEncoding.Attributes;

    [FunctionOutput] // This Works
    public class GetTotalNftTypesFunctionOutputDTO : IFunctionOutputDTO
    {
        [Parameter("uint", "totalNFTs", 1)]
        public int TotalNftTypes { get; set; }
    }
}
