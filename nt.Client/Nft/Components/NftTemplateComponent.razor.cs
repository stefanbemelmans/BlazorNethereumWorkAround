﻿namespace nt.Client.Nft.Components
{
    using nt.Client.Nft.Contracts;
    using Microsoft.AspNetCore.Components;
    using Nethereum.Web3;
    using Nethereum.Web3.Accounts;
    using Nethereum.Contracts;
    using Nethereum.Hex.HexTypes;
    using System;

    public class NftTemplateComponentModel : ComponentBase
{        
    [Parameter] public NftTemplate NftTemplate { get; set; }

    static readonly string NftCreatorAddress = NftCreator.NftCreatorRinkebyAddress;
    static readonly Account Account = new Account(RopstenWeb3.TestRopstenPrivateKey);
    static Web3 web3 = new Web3(Account, RopstenWeb3.RinkebyEndpoint);

    string testFromAddress = RopstenWeb3.TestRopstenAccountAddress;

    Contract NftCreatorContract = web3.Eth.GetContract(NftCreator.Abi, NftCreatorAddress);

    AddNewNftTemplateFunction AddNewNftFunction = NftCreatorContract.GetFunction("NFTTemplates");

    var AddNewTemplateHandler = web3.Eth.GetContractTransactionHandler<MintNftFunction>
    ();

    public async Task MintNft()
    {

    NewTemplateFunctionMessage.Gas = new HexBigInteger(900000);

    var transactionReceipt = await AddNewTemplateHandler.SendRequestAndWaitForReceiptAsync(NftCreatorAddress, NewTemplateFunctionMessage);

    Console.WriteLine($"{transactionReceipt.TransactionHash}");

    }
    }
    }