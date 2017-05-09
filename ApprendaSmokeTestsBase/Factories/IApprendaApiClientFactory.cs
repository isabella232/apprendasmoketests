using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprendaSmokeTestsBase.Services;
using ApprendaSmokeTestsBase.ValueItems;

namespace ApprendaSmokeTestsBase.Factories
{
    public interface IApprendaApiClientFactory
    {
        IApprendaApiClient GetV1Client(ApiPortals apiPortalsToUse);
    }
}
