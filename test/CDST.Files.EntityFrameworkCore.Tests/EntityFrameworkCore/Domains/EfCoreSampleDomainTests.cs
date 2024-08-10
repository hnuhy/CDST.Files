using CDST.Files.Samples;
using Xunit;

namespace CDST.Files.EntityFrameworkCore.Domains;

[Collection(FilesTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<FilesEntityFrameworkCoreTestModule>
{

}
