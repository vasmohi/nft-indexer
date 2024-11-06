using AeFinder.Sdk.Dtos;
using AElf.Contracts.MultiToken;

namespace TokenAeIndexer.GraphQL;

public class AccountNFTDto : AeFinderEntityDto
{
    public string Address { get; set; }
    public string Symbol { get; set; }
    public long Amount { get; set; }
    public ExternalInfo ExternalInfo { get; set; }
}