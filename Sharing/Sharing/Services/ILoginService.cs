using System;
using System.Collections.Generic;
using System.Text;

namespace Sharing.Services
{
    public interface ILoginService
    {
        bool login(string username, string password);
    }
}
