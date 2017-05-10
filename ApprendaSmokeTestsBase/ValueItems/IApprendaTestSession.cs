using System;
using System.Threading.Tasks;
using ApprendaAPIClient;

namespace ApprendaSmokeTestsBase.ValueItems
{
    /// <summary>
    /// Represents connection info and other platform tie ins for a single test
    /// </summary>
    public interface IApprendaTestSession : IDisposable
    {
        Task<IApprendaApiClient> GetClient(ApiPortals portalsToUse);
    }
}
