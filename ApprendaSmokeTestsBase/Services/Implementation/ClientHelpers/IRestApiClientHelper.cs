using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprendaSmokeTestsBase.Services.Implementation.ClientHelpers
{
    public interface IRestApiClientHelper
    {
        UriBuilder ApiRoot { get; }
        RestAuthenticator Authenticator { get; }
    }
}
