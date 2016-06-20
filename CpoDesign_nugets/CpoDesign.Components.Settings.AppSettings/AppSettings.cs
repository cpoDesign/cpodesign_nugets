using System.ComponentModel.Composition;
using System.Configuration;


namespace CpoDesign.Components.Settings.AppSettings
{
    //[Export(typeof(ISettings))]
    public class AppSettings 
    {
        public string Get(string keyName)
        {
            return ConfigurationManager.AppSettings.Get(keyName);
        }
    }
}

