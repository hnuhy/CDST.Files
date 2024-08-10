using CDST.Files.Samples;
using Xunit;

namespace CDST.Files.EntityFrameworkCore.Applications;

[Collection(FilesTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<FilesEntityFrameworkCoreTestModule>
{

}
