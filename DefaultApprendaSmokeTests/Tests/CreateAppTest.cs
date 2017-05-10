using System.Linq;
using System.Threading.Tasks;
using ApprendaSmokeTestsBase.ValueItems;
using Xunit;

namespace DefaultApprendaSmokeTests.Tests
{
    public class CreateAppTest : EasySmokeTest
    {
        [Fact]
        public async Task ApplicationsExistOnPlatform()
        {
            using (var session = StartSession())
            {
                var client = await session.GetClient(ApiPortals.Developer);

                var apps = (await client.GetApplications()).ToList();

                Assert.True(apps.Any());
                var first = apps.First();

                Assert.False(string.IsNullOrWhiteSpace(first.Alias));
            }
        }
    }
}
