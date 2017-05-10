﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprendaAPIClient.Services.ClientHelpers;

namespace ApprendaAPIClient
{
    public abstract class BaseApprendaApiClient
    {
        protected string SessionToken;
        protected readonly IConnectionSettings ConnectionSettings;

        protected readonly string AppsRoot;

        protected BaseApprendaApiClient(IConnectionSettings connectionSettings)
        {
            ConnectionSettings = connectionSettings;

            AppsRoot = connectionSettings.AppsUrl;
        }

        public Task<string> Login(string userName, string password)
        {
            if (string.IsNullOrEmpty(SessionToken))
            {
                var helper = new GenericApiHelper(ConnectionSettings, "developer");
                SessionToken = helper?.Authenticator?.Login(userName, password);
            }

            return Task.FromResult(SessionToken);
        }

        public Task Logout(string sessionToken)
        {
            var helper = new GenericApiHelper(ConnectionSettings, "developer");
            helper?.Authenticator.Logout(SessionToken);
            SessionToken = null;

            return Task.FromResult(false);
        }
    }
}
