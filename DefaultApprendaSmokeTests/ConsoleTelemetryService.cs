using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprendaSmokeTestsBase.Services;

namespace DefaultApprendaSmokeTests
{
    internal class ConsoleTelemetryService : ITelemetryReportingService
    {
        public Task ReportInfo(string message, IEnumerable<string> tags)
        {
            Console.WriteLine(message + "::" + string.Join(", " ,tags));

            return Task.FromResult(false);
        }
    }
}
