using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ApprendaAPIClient.Models.SOC;
using ApprendaSmokeTestsBase.ValueItems;
using Xunit;

namespace DefaultApprendaSmokeTests.Tests
{
    public class HealthReportSmokeTest : EasySmokeTest
    {
        [InlineData(2)]
        [Theory]
        public async Task CheckHealthReportsStayValidForSetNumberOfMinutes(int numMinutes, int numSecondsBetweenChecks = 20)
        {
            IEnumerable<string> allHostNames;
            //get our host names, we'll be running reports on all of them!
            using (var session = StartSession())
            {
                var client = await session.GetClient(ApiPortals.SOC);

                var hosts = await client.GetAllHosts();

                allHostNames = hosts.Select(h => h.Name);
            }


            var hostTasks = allHostNames.Select(hn => CycleHealthReportChecks(numMinutes, numSecondsBetweenChecks, hn));

            await Task.WhenAll(hostTasks.ToArray());
        }

        private async Task CycleHealthReportChecks(int numMinutes, int numSecondsBetweenChecks, string hostName)
        {
            var endAt = DateTime.UtcNow.AddMinutes(numMinutes);
            while (DateTime.UtcNow < endAt)
            {
                await LastHealthReportIsHealthy(hostName);
                await Task.Delay(TimeSpan.FromSeconds(numSecondsBetweenChecks));
            }
        }


        [InlineData("")]
        [Theory]
        public async Task LastHealthReportIsHealthy(string hostName)
        {
            using (var session = StartSession())
            {
                var client = await session.GetClient(ApiPortals.SOC);

                var hosts = await client.GetAllHosts();

                var host = string.IsNullOrWhiteSpace(hostName)
                    ? hosts.FirstOrDefault()
                    : hosts.FirstOrDefault(h => h.Name == hostName);

                Assert.NotNull(host);
                Assert.False(string.IsNullOrWhiteSpace(host.Name));

                var reports = await client.GetHealthReports(host.Name);

                Assert.NotNull(reports);
                Assert.True(reports.Items.Any());

                var lastReport = reports.Items.Last();
                Assert.Equal(lastReport.Outcome, HealthOutcome.Healthy);
                Assert.Equal(lastReport.Result, HealthCheckResultType.Normal);

            }
        }
    }
}
