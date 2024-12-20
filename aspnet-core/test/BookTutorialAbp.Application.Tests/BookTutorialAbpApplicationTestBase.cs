using Volo.Abp.Modularity;

namespace BookTutorialAbp;

public abstract class BookTutorialAbpApplicationTestBase<TStartupModule> : BookTutorialAbpTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
