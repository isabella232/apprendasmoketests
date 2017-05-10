using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprendaSmokeTestsBase.ValueItems;

namespace ApprendaSmokeTestsBase.Repositories
{
    public interface IUserLoginRepository
    {
        /// <summary>
        /// Assumes we have a pool of user logins and wish to get the next one
        /// </summary>
        /// <returns></returns>
        IUserLogin GetNextAvailableUserLogin();
    }
}
