using AElf.Contracts.MultiToken;

namespace TokenAeIndexer.GraphQL;

public class GetAccountNFTInput
{
    public string ChainId { get; set; }
    public string Address { get; set; }
    public string Symbol { get; set; }
    public ExternalInfo ExternalInfo { get; set; }
}