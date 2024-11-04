using AeFinder.App.TestBase;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace TokenAeIndexer;

[DependsOn(
    typeof(AeFinderAppTestBaseModule),
    typeof(TokenAeIndexerModule))]
public class TokenAeIndexerTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AeFinderAppEntityOptions>(options => { options.AddTypes<TokenAeIndexerModule>(); });
        
        // Add your Processors.
        // context.Services.AddSingleton<MyLogEventProcessor>();
    }
}