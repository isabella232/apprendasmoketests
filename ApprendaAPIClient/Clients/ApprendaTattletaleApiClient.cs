using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ApprendaAPIClient.Services;

namespace ApprendaAPIClient.Clients
{
    /// <summary>
    /// Version of the API client which can get injected with a reporter to send information back about requests
    /// </summary>
    internal class ApprendaTattletaleApiClient : ApprendaApiClient
    {
        private readonly ITelemetryReportingService _reportingService;

        public ApprendaTattletaleApiClient(IConnectionSettings connectionSettings, ITelemetryReportingService reportingService) 
            : base(connectionSettings)
        {
            _reportingService = reportingService;
        }

        protected override async Task<T> GetResultAsync<T>(string path, string helperType = "developer", [CallerMemberName] string callingMethod = "")
        {
            var tags = new List<string> {"clientcall", callingMethod};
            await _reportingService.ReportInfo("Starting request to " + path, tags);
            var res = await base.GetResultAsync<T>(path, helperType);
            await _reportingService.ReportInfo("Finished request to " + path, tags);

            return res;
        }
    }
}
