using IdentityModel.Client;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Month12.IIds4Service
{
    public class Ids4Service
    {
        private IConfiguration _configuration;

        public Ids4Service(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<string> GetIdsTokenAsync(string loginName, string Loginpwd)
        {
            var client = new HttpClient();
            var idsTokenUrl = _configuration.GetSection("AuthServer:Authority").Value;  //ids4访问url地址
            var AppClientId = _configuration.GetSection("AuthServer:AuthoritId").Value;  //ids4访问
            var AppClientSecret = _configuration.GetSection("AuthServer:AuthoritSecret").Value;  //ids4访问密码
            //var AppClientSecret = this._configuration.CetSection("AuthServer: AppClientSecret").value;//ids4访
            var disco = client.GetDiscoveryDocumentAsync(idsTokenUrl);

            var tokenResponse = await client.RequestPasswordTokenAsync(
                new PasswordTokenRequest
                {
                    Address = disco.Result.TokenEndpoint,
                    ClientId = AppClientId,
                    ClientSecret = AppClientSecret,
                    UserName = loginName,
                    Password = Loginpwd
                }
                );

            if (tokenResponse.IsError)
            {
                return string.Empty;
            }
            return tokenResponse.AccessToken;
        }

    }
}
