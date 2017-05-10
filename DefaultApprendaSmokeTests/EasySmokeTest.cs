using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprendaSmokeTestsBase.Repositories;
using ApprendaSmokeTestsBase.Services;

namespace DefaultApprendaSmokeTests
{
    /// <summary>
    /// A smoke test using very basic reporting and other injections
    /// </summary>
    public abstract class EasySmokeTest : ApprendaSmokeTestsBase.BaseSmokeTest
    {
        protected EasySmokeTest():
            base(new EasyConnectionSettingsFactory(), null, new ConsoleTelemetryService())
        {

        }
    }
}
