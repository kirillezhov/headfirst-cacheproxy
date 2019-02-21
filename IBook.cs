using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheProxy
{
    interface IBook : IDisposable
    {
        Models.Page GetPage(int number);
    }
}
