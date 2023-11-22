using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreApi.Data.Infrastructure
{
    /* This class is use for Interface of the UnitOfWork */
    public interface IUnitOfWork
    {
        void Commit();
    }
}
