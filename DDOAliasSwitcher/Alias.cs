using System.Collections.Specialized;
using System.Configuration;
using System.Xml;
using System.Xml.Linq;

namespace DDOAliasSwitcher
{
    internal class Aliases
    {
        Dictionary<string, string> AliasLines = new Dictionary<string, string>();

        internal void ScrubFile(string fileLoc)
        {
            XDocument layoutFile = XDocument.Load(fileLoc);

            var query = from node in layoutFile.Descendants("Alias")
                        select node;
            query.ToList().ForEach(x => x.Remove());

            var query1 = from node in layoutFile.Descendants("Aliases")
                         select node;
            query1.ToList().ForEach(x => x.Remove());

            layoutFile.Save(fileLoc);
        }

        internal void WriteNewNodes(Dictionary<string, string> aliasLines, string fileLoc)
        {
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

        #region Alias Text
        internal Dictionary<string, string> CompileFromDefaultFile(string defaultFileLoc)
        {
            XDocument layoutFile = XDocument.Load(defaultFileLoc);

            var query = from node in layoutFile.Descendants("Alias")
                        select node;

            foreach (var alias in query.ToList())
            {
                string first = (string)alias.Attribute("String");
                string second = (string)alias.Attribute("Value");

                AliasLines.Add(first, second);
            }

            return AliasLines;
        }

        internal Dictionary<string, string> CompileRaids(List<string> raidSelection)
        {
            AliasColors();

            string keyLines = "";
            foreach (string raid in raidSelection)
            {
                string raidName = raid.Replace("CheckBox", "");
                NameValueCollection RaidAliases = (NameValueCollection)ConfigurationManager.GetSection(raidName);

                if (RaidAliases.Count > 0)
                {
                    foreach (var alias in RaidAliases)
                    {
                        var key = Convert.ToString(alias);
                        var value = RaidAliases[key];
                        AliasLines.Add(key, value);

                        keyLines += $"{key}, ";
                    }
                }
            }

            AliasLines.Add(";list", $"/p {keyLines}");

            return AliasLines;
        }

        private void AliasColors()
        {
            NameValueCollection colors = (NameValueCollection)ConfigurationManager.GetSection("Colors");

            if (colors.Count > 0)
            {
                foreach (var color in colors)
                {
                    var colorKey = Convert.ToString(color);
                    var colorValue = colors[colorKey];
                    AliasLines.Add(colorKey, colorValue);
                }
            }
        }
        #endregion
    }
}
