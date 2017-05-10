using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprendaSmokeTestsBase.ValueItems;

namespace ApprendaSmokeTestsBase.Services.Implementation.ClientHelpers
{
    internal class AccountApiHelper : IRestApiClientHelper
    {
        private readonly IRestApiClientHelper _genericApiHelper;

        public AccountApiHelper(IConnectionSettings connectionSettings)
        {
            _genericApiHelper = new GenericApiHelper(connectionSettings, "account");
        }

        public UriBuilder ApiRoot => _genericApiHelper.ApiRoot;

        public RestAuthenticator Authenticator => _genericApiHelper.Authenticator;
    }
}
