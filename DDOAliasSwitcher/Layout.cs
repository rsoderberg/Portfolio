using System.ComponentModel.Design.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace DDOAliasSwitcher
{
    internal class Layout
    {
        internal void EditXMLForRaidDay(string raidDay, string fileLoc)
        {
            fileLoc = "C:\\Users\\r_sod\\Documents\\Dungeons and Dragons Online\\ui\\layouts\\test.layout";

            //XDocument layoutFile = XDocument.Load(fileLoc);

            //var query = from node in layoutFile.Descendants("Alias")
            //            select node;
            //query.ToList().ForEach(x => x.Remove());

            //layoutFile.Save(fileLoc);

            ////////////

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(fileLoc);

            XmlNode node = xmlDoc.CreateNode(XmlNodeType.Element, "Alias", null);
            XmlAttribute String = xmlDoc.CreateAttribute("String");
            String.Value = ";b";

            XmlAttribute Value = xmlDoc.CreateAttribute("Value");
            Value.Value = "/p ;green This is my test";

            node.Attributes.Append(String);
            node.Attributes.Append(Value);

            xmlDoc.DocumentElement.AppendChild(node);

            xmlDoc.Save(fileLoc);
        }
    }
}

// Modify the user's inputted .layout XML file. You should be able to modify only the <Aliases></Aliases> node.
// https://stackoverflow.com/questions/2551307/modify-xml-existing-content-in-c-sharp

/*
  <Aliases>
    <Alias String=";b" Value="/p ;green This is my test"/>
    <Alias String=";gm" Value="/g ;babyblue It's a really great test!"/>
    <Alias String=";pw" Value="/g ;gold Nobody tests as well as I test"/>
    <Alias String=";t" Value="/p ;red That's probably a lie"/>
    <Alias String=";w" Value="/g ;green BUT WHO'S GOING TO STOP ME! :)"/>

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
