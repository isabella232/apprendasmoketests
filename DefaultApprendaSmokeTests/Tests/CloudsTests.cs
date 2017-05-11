using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprendaAPIClient.Models;
using ApprendaAPIClient.Models.AccountPortal;
using ApprendaSmokeTestsBase.ValueItems;
using Xunit;

namespace DefaultApprendaSmokeTests.Tests
{
    public class CloudsTests : EasySmokeTest
    {
        [Fact]
        public async Task GetCloudsReturnsAllAndById()
        {
            using (var session = StartSession())
            {
                var client = await session.GetClient(ApiPortals.SOC);

                 var clouds = await client.GetClouds();

                var cloud = clouds.Items?.FirstOrDefault();
                Assert.NotNull(cloud);


                var directQuery = await client.GetCloud(cloud.Id);

                Assert.Equal(directQuery.Id, cloud.Id);
                Assert.False(string.IsNullOrWhiteSpace(directQuery.Href));
            }
        }
    }
}
