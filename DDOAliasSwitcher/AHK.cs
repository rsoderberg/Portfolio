using System.Diagnostics;

namespace DDOAliasSwitcher
{
    internal class AHK
    {
        internal void ReloadLayoutInDDO()  
        {
            string AHKScriptName = Path.Combine(Environment.CurrentDirectory, @"assets\", "LayoutScript.exe");
            Process.Start(AHKScriptName);
        }
    }
}
