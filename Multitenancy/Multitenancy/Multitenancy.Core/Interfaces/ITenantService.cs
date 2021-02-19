using System;
using System.Collections.Generic;
using System.Text;

namespace Multitenancy.Core.Interfaces
{
    public interface ITenantService
    {
        bool ExistingFeature(string parameter);

        string Greeting { get; }
    }
}
