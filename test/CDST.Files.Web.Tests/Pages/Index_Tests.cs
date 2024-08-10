using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace CDST.Files.Pages;

[Collection(FilesTestConsts.CollectionDefinitionName)]
public class Index_Tests : FilesWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
