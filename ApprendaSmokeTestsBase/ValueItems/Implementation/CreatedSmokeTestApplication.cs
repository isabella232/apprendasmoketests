﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprendaAPIClient;
using ApprendaSmokeTestsBase.Services;

namespace ApprendaSmokeTestsBase.ValueItems.Implementation
{
    /// <summary>
    /// Smoke test application which is also able to know it should destroy itself on the platform once disposed
    /// </summary>
    public class CreatedSmokeTestApplication : SmokeTestApplication, IDisposable
    {
        /// <summary>
        /// Client to use to clean up with
        /// </summary>
        private readonly IApprendaApiClient _client;

        public Boolean WasCreated { get; set; }
        public CreatedSmokeTestApplication(IApprendaApiClient client, ISmokeTestApplication source)
        {
            AppAlias = source.AppAlias;
            SmokeTestApplicationName = source.SmokeTestApplicationName;
            _client = client;
        }

        public void Dispose()
        {
            if (WasCreated)
            {
                _client.DeleteApplication(AppAlias);
            }
        }
    }
}
