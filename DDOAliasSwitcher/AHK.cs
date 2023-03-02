using AutoHotkey.Interop;
using System.Collections.Specialized;
using System.Configuration;

namespace DDOAliasSwitcher
{
    internal class AHK
    {
        internal void ReloadLayoutInDDO()  
        {
            NameValueCollection UserSettings = (NameValueCollection)ConfigurationManager.GetSection("UserSettings");

            try
            {
                string AHKScriptName = UserSettings[3];

                AutoHotkeyEngine.Instance.LoadFile(AHKScriptName);
                AutoHotkeyEngine.Instance.LoadScript(AHKScriptName);
            }
            catch (Exception ex)
            {
                // Do nothing!
            }
        }
    }
}
