﻿namespace nt.Client.Server.Services.Web3.Contracts
{   // [Function("name", "return type")]
    using Nethereum.ABI.FunctionEncoding.Attributes;
    using Nethereum.Contracts;

    // [Parameter("type", "paramName", order)]

    [Function(name: "totalNFTs", returnType: "uint")]
    public class GetTotalNftTypesFunction : FunctionMessage
    {

    }
}