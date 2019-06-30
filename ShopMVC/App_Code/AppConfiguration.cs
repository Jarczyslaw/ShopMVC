using System.Configuration;
using System.Runtime.CompilerServices;

namespace ShopMVC.App_Code
{
    internal class AppConfiguration : IAppConfiguration
    {
        public string Test => GetConfigValue();

        public string GetConfigValue([CallerMemberName]string key = null)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}