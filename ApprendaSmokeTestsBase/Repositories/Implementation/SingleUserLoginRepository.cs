using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprendaAPIClient;
using ApprendaAPIClient.Factories;
using ApprendaSmokeTestsBase.ValueItems;

namespace ApprendaSmokeTestsBase.Repositories.Implementation
{
    /// <summary>
    /// Simple repository that simply redirects any call for a user to connection settings.  Means only one login
    /// </summary>
    internal class SingleUserLoginRepository : IUserLoginRepository
    {
        private readonly IConnectionSettingsFactory _connectionSettingsFactory;
     
        public SingleUserLoginRepository(IConnectionSettingsFactory connectionSettingsFactory)
        {
            _connectionSettingsFactory = connectionSettingsFactory;
        }

        public IUserLogin GetNextAvailableUserLogin()
        {
            var settings = _connectionSettingsFactory.GetConnectionSettings();

            return settings.UserLogin;
        }
    }
}
