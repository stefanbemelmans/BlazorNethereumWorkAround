namespace nt.Client.Nft.Contracts
{
    using Nethereum.Contracts;
    using Nethereum.Hex.HexTypes;
    using Nethereum.Web3;

    public class NftCreator
    {
        public static Web3 web3 = new Web3();
        public static string NftCreatorRopstenAddress= "0x414bABeEc0a0Faa22D9FdbfaE461ace4c632a020";
        public static string NftCreatorRinkebyAddress= "0x10DF15C1BD76050E96f04C44cE11a5e5CA0e935e";

        public static string Abi = NftCreatorAbi.Abi;
        Contract NftCreatorContract = web3.Eth.GetContract(Abi, NftCreatorRinkebyAddress);
    }
}