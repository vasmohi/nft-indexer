using AeFinder.Sdk.Entities;
using AElf.Contracts.MultiToken;
using Nest;

namespace TokenAeIndexer.Entities;

public class AccountNFT: AeFinderEntity, IAeFinderEntity
{
    [Keyword] public string Address { get; set; }
    [Keyword] public string Symbol { get; set; }
    public long Amount { get; set; }
    public ExternalInfo ExternalInfo { get; set; }
}