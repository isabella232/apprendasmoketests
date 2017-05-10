using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprendaAPIClient;
using ApprendaSmokeTestsBase.ValueItems;

namespace ApprendaSmokeTestsBase.Factories
{
    /// <summary>
    /// Produces connection settings, and allows injection of new methods to do so 
    /// </summary>
    public interface IConnectionSettingsFactory
    {
        IConnectionSettings GetConnectionSettings();
    }
}
