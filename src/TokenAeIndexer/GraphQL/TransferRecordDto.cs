using AeFinder.Sdk.Dtos;
using AElf.Contracts.MultiToken;

namespace TokenAeIndexer.GraphQL;

public class TransferRecordDto : AeFinderEntityDto
{
    public string Symbol { get; set; }
    public string FromAddress { get; set; }
    public string ToAddress { get; set; }
    public long Amount { get; set; }
    //public ExternalInfo ExternalInfo { get; set; }
}