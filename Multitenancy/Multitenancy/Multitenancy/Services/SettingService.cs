using Multitenancy.Core.Interfaces;
using Multitenancy.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Multitenancy.Services
{
    public class SettingService : ISettingService
    {
        public string ProjectId { get { return Secrets.ProjectId; } }
        public string[] Features { get { return JsonConvert.DeserializeObject<string[]>(Secrets.Features); } }
    }
}
