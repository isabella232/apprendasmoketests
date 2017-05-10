using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprendaSmokeTestsBase.Repositories;
using ApprendaSmokeTestsBase.ValueItems;

namespace DefaultApprendaSmokeTests
{
    class NoOpSmokeTestApplicationRepository : ISmokeTestApplicationRepository
    {
        public Task<ISmokeTestApplication> GetSmokeTestApplication(string smokeTestApplicationName)
        {
            return Task.FromResult((ISmokeTestApplication)null);
        }
    }
}
