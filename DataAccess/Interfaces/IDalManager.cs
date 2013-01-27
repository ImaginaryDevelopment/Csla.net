using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public interface IDalManager : IDisposable
    {
        T GetProvider<T>() where T : class;
    }
}
