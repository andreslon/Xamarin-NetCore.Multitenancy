using Multitenancy.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multitenancy.Core.Services
{
    public class TenantService: ITenantService
    {
        public string[] Features { get; set; }

        public virtual string Greeting =>"Hi Everyone this is the GENERIC app text";

        public TenantService(string[] features)
        {
            Features = features;
        }
        public virtual bool ExistingFeature(string parameter)
        {
            return Features.Any(x => x == parameter);
        }

    }
}
