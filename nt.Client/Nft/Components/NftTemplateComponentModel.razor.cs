namespace nt.Client.Nft.Components
{

using nt.Client.Nft.Contracts;
using nt.Client.Nft.Components;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using Nethereum.Contracts;
using Nethereum.Util;
using Nethereum.Hex.HexTypes;
using System.Numerics;

public class NftTemplateComponentModel : BaseComponent
{


[Parameter] public NftTemplate NftTemplate { get; set; }

    var url = RopstenWeb3.RinkebyEndpoint;
    var NftCreatorAddress = NftCreator.NftCreatorRinkebyAddress;

    var privateKey = RopstenWeb3.TestRopstenPrivateKey;
    var account = new Account(privateKey);
    Web3 web3 = new Web3(account, url);

    var testFromAddress = RopstenWeb3.TestRopstenAccountAddress;

    Contract NftCreatorContract = web3.Eth.GetContract(NftCreator.Abi, NftCreatorAddress);

    var AddNewNftFunction = NftCreatorContract.GetFunction("NFTTemplates");

    var AddNewTemplateHandler = web3.Eth.GetContractTransactionHandler<MintNftFunction>();

public async Task MintNft()
    {

        NewTemplateFunctionMessage.Gas = new HexBigInteger(900000);

        var transactionReceipt = await AddNewTemplateHandler.SendRequestAndWaitForReceiptAsync(NftCreatorAddress, NewTemplateFunctionMessage);

        Console.WriteLine($"{transactionReceipt.TransactionHash}");

    }
}
}