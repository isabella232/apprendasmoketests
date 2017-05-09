using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprendaSmokeTestsBase.Services;

namespace ApprendaSmokeTestsBase.ValueItems.Implementation
{
    /// <summary>
    /// Represents connection info and other platform tie ins for a single test
    /// </summary>
    public interface IApprendaTestSession : IDisposable
    {
        IApprendaApiClient GetClient(ApiPortals portalsToUse = ApiPortals.All);
    }
}
