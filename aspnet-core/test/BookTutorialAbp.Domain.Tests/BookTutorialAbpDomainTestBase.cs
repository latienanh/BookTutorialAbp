using Volo.Abp.Modularity;

namespace BookTutorialAbp;

/* Inherit from this class for your domain layer tests. */
public abstract class BookTutorialAbpDomainTestBase<TStartupModule> : BookTutorialAbpTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
