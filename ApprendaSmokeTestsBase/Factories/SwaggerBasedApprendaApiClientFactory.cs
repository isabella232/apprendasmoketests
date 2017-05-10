﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprendaAPIClient;
using ApprendaSmokeTestsBase.Services;
using ApprendaSmokeTestsBase.Services.Implementation;
using ApprendaSmokeTestsBase.ValueItems;

namespace ApprendaSmokeTestsBase.Factories
{
    public class SwaggerBasedApprendaApiClientFactory : IApprendaApiClientFactory
    {
        private readonly IConnectionSettingsFactory _connectionSettingsFactory;

        public SwaggerBasedApprendaApiClientFactory(IConnectionSettingsFactory connectionSettingsFactory)
        {
            _connectionSettingsFactory = connectionSettingsFactory;
        }

        public IApprendaApiClient GetV1Client(ApiPortals apiPortalsToUse)
        {
            var connectionSettings = _connectionSettingsFactory.GetConnectionSettings();
            return new ApprendaSwaggerApiClient(connectionSettings.AppsUrl);
        }
    }
}
