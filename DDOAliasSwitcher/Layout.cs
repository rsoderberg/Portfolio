using System.Xml.Linq;

namespace DDOAliasSwitcher
{
    internal class Layout
    {
        internal void EditXMLForRaidDay(string raidDay, string fileName)
        {
            XDocument layoutFile = XDocument.Load(fileName);

            var query = from c in layoutFile.Elements("Aliases") select c;
            foreach (XElement alias in query)
            {
                alias.Attribute("attr").Value = "NewValue";
            }
            layoutFile.Save(fileName);

        }
    }
}

// Modify the user's inputted .layout XML file. You should be able to modify only the <Aliases></Aliases> node.
// https://stackoverflow.com/questions/2551307/modify-xml-existing-content-in-c-sharp

/*
  <Aliases>
    <Alias String=";b" Value="/p ;green AFK bio"/>
    <Alias String=";gm" Value="/g ;babyblue SUN 8pm KT x2. TUE 8pm PN x2. FRI 8 pm RL/Lshroud or DOJ/LTS/LShroud. SAT 1 PM LHOX, PN, LShroud, TH. All Times ET (US) :)"/>
    <Alias String=";pw" Value="/g ;gold Please wait for Fal to make raid announcements. Asking will not make it go faster :)"/>
    <Alias String=";t" Value="/p ;red TRAP!"/>
    <Alias String=";w" Value="/g ;green Welcome! Buffs on airship, scheduled stuff in guild message :)"/>

    <Alias String=";babyblue" Value="&lt;rgb=#66CCFF>"/>
    <Alias String=";black" Value="&lt;rgb=#000000>"/>
    <Alias String=";blue" Value="&lt;rgb=#0000FF>"/>
    <Alias String=";darkgrey" Value="&lt;rgb=#666666>"/>
    <Alias String=";gold" Value="&lt;rgb=#FFD700>"/>
    <Alias String=";green" Value="&lt;rgb=#00FF00>"/>
    <Alias String=";grey" Value="&lt;rgb=#999999>"/>
    <Alias String=";hotpink" Value="&lt;rgb=#FF0099>"/>
    <Alias String=";lblue" Value="&lt;rgb=#66CCFF>"/>
    <Alias String=";lgreen" Value="&lt;rgb=#99FF99>"/>
    <Alias String=";limegreen" Value="&lt;rgb=#99FF99>"/>
    <Alias String=";pink" Value="&lt;rgb=#FF99CC>"/>
    <Alias String=";purple" Value="&lt;rgb=#800080>"/>
    <Alias String=";red" Value="&lt;rgb=#FF0000>"/>
    <Alias String=";seagreen" Value="&lt;rgb=#339999>"/>
    <Alias String=";sgreen" Value="&lt;rgb=#339999>"/>
    <Alias String=";white" Value="&lt;rgb=#FFFFFF>"/>
    <Alias String=";yellow" Value="&lt;rgb=#FFFF00>"/>
  </Aliases>
*/
