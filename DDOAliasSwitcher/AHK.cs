using AutoHotkey.Interop;
using System.Collections.Specialized;
using System.Configuration;

namespace DDOAliasSwitcher
{
    internal class AHK
    {
        internal void ReloadLayoutInDDO()  
        {
            // https://www.nuget.org/packages/AutoHotkey.Interop/1.0.0.1#show-readme-container

            try
            {
                string AHKScriptName = Path.Combine(Environment.CurrentDirectory, @"assets\", "LayoutScript.ahk");

                var autoHotKey = AutoHotkeyEngine.Instance;
                autoHotKey.LoadFile(AHKScriptName);
                autoHotKey.LoadScript(AHKScriptName);
            }
            catch (Exception ex)
            {
                // Do nothing!
            }
        }
    }
}
