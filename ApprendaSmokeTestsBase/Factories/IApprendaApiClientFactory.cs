using ApprendaAPIClient;
using ApprendaSmokeTestsBase.ValueItems;

namespace ApprendaSmokeTestsBase.Factories
{
    public interface IApprendaApiClientFactory
    {
        IApprendaApiClient GetV1Client(ApiPortals apiPortalsToUse);
    }
}
