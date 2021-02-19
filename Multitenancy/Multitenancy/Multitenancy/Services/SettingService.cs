using Multitenancy.Core.Interfaces;
using Multitenancy.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Multitenancy.Services
{
    public class SettingService : ISettingService
    {
        public string ProjectId()
        {
            return Secrets.ProjectId;
        }
    }
}
