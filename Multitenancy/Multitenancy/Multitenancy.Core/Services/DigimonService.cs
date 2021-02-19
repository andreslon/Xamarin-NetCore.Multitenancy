using Multitenancy.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Multitenancy.Core.Services
{
    public class DigimonService : TenantService, ITenantService
    {
        public DigimonService(string[] features) : base(features)
        {

        }
        public override string Greeting => "Hi and welcome to Digimon App :*";
    }
}
