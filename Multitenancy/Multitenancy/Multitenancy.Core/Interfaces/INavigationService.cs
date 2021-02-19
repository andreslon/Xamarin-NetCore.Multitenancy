using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Multitenancy.Core.Interfaces
{
    public interface INavigationService
    {
        Task GoToAsync(string page, string id = null);
    }
}
