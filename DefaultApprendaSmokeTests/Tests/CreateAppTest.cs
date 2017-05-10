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
                var firstApplication = apps.First();

                Assert.False(string.IsNullOrWhiteSpace(firstApplication.Alias));

                var reget = await client.GetApplication(firstApplication.Alias);

                Assert.NotNull(reget);

                var versions = (await client.GetVersionsForApplication(firstApplication.Alias)).ToList();

                Assert.NotNull(versions);
                Assert.True(versions.Any());

                var singleVersion = await client.GetVersion(firstApplication.Alias, versions.First().Alias);

                Assert.NotNull(singleVersion);
                Assert.Equal(versions.First().Alias, singleVersion.Alias);
            }
        }
    }
}
