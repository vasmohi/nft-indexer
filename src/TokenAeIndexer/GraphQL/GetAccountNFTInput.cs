namespace TokenAeIndexer.GraphQL;

public class GetAccountNFTInput
{
    public string ChainId { get; set; }
    public string Address { get; set; }
    public string Symbol { get; set; }
    public ??? ExternalInfo { get; set; }
}