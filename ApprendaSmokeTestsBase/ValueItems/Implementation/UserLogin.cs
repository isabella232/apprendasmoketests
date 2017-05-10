using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprendaSmokeTestsBase.ValueItems.Implementation
{
    public class UserLogin : IUserLogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
