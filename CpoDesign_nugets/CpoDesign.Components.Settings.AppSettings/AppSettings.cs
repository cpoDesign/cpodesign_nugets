using System.ComponentModel.Composition;
using System.Configuration;
using CpoDesign.Components.Settings.Interface;

namespace CpoDesign.Components.Settings.AppSettings
{
    [Export(typeof(ISettings))]
    public class AppSettings : ISettings
    {
        public string Get(string keyName)
        {
            return ConfigurationManager.AppSettings.Get(keyName);
        }
    }
}