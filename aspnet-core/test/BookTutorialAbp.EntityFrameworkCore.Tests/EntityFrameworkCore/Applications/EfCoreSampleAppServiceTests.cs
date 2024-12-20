using BookTutorialAbp.Samples;
using Xunit;

namespace BookTutorialAbp.EntityFrameworkCore.Applications;

[Collection(BookTutorialAbpTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BookTutorialAbpEntityFrameworkCoreTestModule>
{

}
