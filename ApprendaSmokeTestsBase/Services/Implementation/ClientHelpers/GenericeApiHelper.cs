﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprendaSmokeTestsBase.ValueItems;

namespace ApprendaSmokeTestsBase.Services.Implementation.ClientHelpers
{
    internal class GenericApiHelper : IRestApiClientHelper
    {
        private readonly IConnectionSettings _propertyRetriever;
        private readonly string _portal;
        private RestAuthenticator _authenticator;

        public GenericApiHelper(IConnectionSettings propertyRetriever, string portal)
        {
            _propertyRetriever = propertyRetriever;
            _portal = portal;
        }

        public UriBuilder ApiRoot => new UriBuilder(_propertyRetriever.AppsUrl)
        {
            Path = $"{_portal}/api/v1/"
        };

        public RestAuthenticator Authenticator
            =>
                _authenticator ??
                (_authenticator = new RestAuthenticator(new DefaultRestApiContext(_propertyRetriever.AppsUrl), _portal));
    }
}
