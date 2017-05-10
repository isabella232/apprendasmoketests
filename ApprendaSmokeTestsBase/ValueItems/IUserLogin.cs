using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprendaSmokeTestsBase.ValueItems
{
    public interface IUserLogin
    {
        string UserName { get; set; }
        string Password { get; set; }
    }
}
