using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprendaSmokeTestsBase.Services.Implementation.ClientHelpers
{
    internal class DefaultRestApiContext : IRestApiContext
    {
        public DefaultRestApiContext(string cloudUrl)
        {
            CloudUrl = cloudUrl;
        }

        public bool IsLegacyToken { get { return false; } }

        public string AuthToken { get; set; }

        public string CloudUrl { get; set; }
    }
}
