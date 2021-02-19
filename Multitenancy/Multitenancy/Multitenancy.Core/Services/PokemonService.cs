using Multitenancy.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Multitenancy.Core.Services
{
    public class PokemonService : TenantService, ITenantService
    {
        public PokemonService(string[] features) : base(features)
        {

        }
    }
}
