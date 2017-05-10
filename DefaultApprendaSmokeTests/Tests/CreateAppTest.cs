using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                var client = session.GetClient(ApiPortals.Developer);

                var apps = await client.GetAllApplications();
            }
        }
    }
}
