namespace DDOAliasSwitcher
{
    internal class LayoutBuilder
    {
        internal void EditXMLForRaidDay(Dictionary<string, string> aliasLines, string fileLoc)
        {
            Aliases aliases = new Aliases();

            // if file is not empty
            // Need to add XML node stuffs
            if (new FileInfo(fileLoc).Length > 0)
                aliases.ScrubFile(fileLoc);

            aliases.WriteNewNodes(aliasLines, fileLoc);
        }
    }
}
