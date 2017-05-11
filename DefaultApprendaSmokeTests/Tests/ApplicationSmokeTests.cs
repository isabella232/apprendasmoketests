using System;
using System.Linq;
using System.Threading.Tasks;
using ApprendaAPIClient.Models.DeveloperPortal;
using ApprendaSmokeTestsBase.ValueItems;
using Xunit;

namespace DefaultApprendaSmokeTests.Tests
{
    public class ApplicationSmokeTests : EasySmokeTest
    {
        [InlineData("HelloWorld")]
        [Theory]
        public async Task ApplicationIsCreatedOnPlatform(string smokeTestAppToUse)
        {
            using (var session = StartSession())
            {
                var randomVal = new Random(DateTime.Now.Millisecond).Next(10000);
                var alias = smokeTestAppToUse + randomVal;
                await DeleteAppIfExists(alias);

                var href = session.ConnectionSettings.AppsUrl + $"/developer/api/v1/apps/{alias}";
                var app = new Application(href)
                {
                    Alias = alias,
                    Description = $"Created by REST API {randomVal}",
                    Name = $"Created by REST API {randomVal}",
                    Href = href
                };

                var client = await session.GetClient(ApiPortals.Developer);
                var res = await client.PostApp(app);

                Assert.True(res);

                //check it exists!
                var getRes = await client.GetApplication(app.Alias);

                Assert.NotNull(getRes);
                Assert.Equal(app.Alias.ToLower(), getRes.Alias.ToLower());
                Assert.Equal(app.Description, getRes.Description);
                Assert.Equal(app.Name, getRes.Name);
                Assert.Equal(app.Href, getRes.Href);

                //check promotion?

                await DeleteAppIfExists(alias);
            }
        }

        [Fact]
        public async Task ApplicationsExistOnPlatformAndHaveVersion()
        {
            using (var session = StartAdminSession())
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
