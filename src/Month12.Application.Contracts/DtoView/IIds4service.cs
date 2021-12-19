using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Month12.DtoView
{
    public interface IIds4service
    {
        Task<string> GetIdsTokenAsync(string loginName, string Loginpwd);
    }
}
