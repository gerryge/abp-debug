using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Dyabp.DyProjectName.Pages
{
    public class Index_Tests : DyProjectNameWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
