using System.Xml;

namespace DDOAliasSwitcher
{
    internal class Layout
    {
        internal void EditXMLForRaidDay(Dictionary<string, string> aliasLines, string fileLoc)
        {
            fileLoc = "C:\\Users\\r_sod\\Documents\\Dungeons and Dragons Online\\ui\\layouts\\test.layout";
            //fileLoc = "C:\\Users\\r_sod\\Documents\\Dungeons and Dragons Online\\ui\\layouts\\bigscreen.layout";

            // Delete the current Aliases and Alias nodes
            Aliases aliases = new Aliases();
            aliases.ScrubFile(fileLoc);

            // Create new Aliases and Alias nodes
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(fileLoc);

            XmlNode aliasesNode = xmlDoc.CreateNode(XmlNodeType.Element, "Aliases", null);

            foreach (var alias in aliasLines)
            {
                XmlNode aliasNode = xmlDoc.CreateNode(XmlNodeType.Element, "Alias", null);

                XmlAttribute String = xmlDoc.CreateAttribute("String");
                XmlAttribute Value = xmlDoc.CreateAttribute("Value");

                String.Value = alias.Key;
                Value.Value = alias.Value;

                aliasNode.Attributes.Append(String);
                aliasNode.Attributes.Append(Value);

                XmlElement aliasesElement = (XmlElement)xmlDoc.DocumentElement.AppendChild(aliasesNode);
                aliasesElement.AppendChild(aliasNode);
            }

            xmlDoc.Save(fileLoc);
        }
    }
}
