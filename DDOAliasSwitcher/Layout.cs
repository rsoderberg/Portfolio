namespace DDOAliasSwitcher
{
    internal class LayoutBuilder
    {
        internal void EditXMLForRaidDay(Dictionary<string, string> aliasLines, string fileLoc)
        {
            Aliases aliases = new Aliases();

            aliases.ScrubFile(fileLoc);
            aliases.WriteNewNodes(aliasLines, fileLoc);
        }
    }
}
