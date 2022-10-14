namespace DDOAliasSwitcher
{
    internal class LayoutBuilder
    {
        internal void EditXMLForRaidDay(Dictionary<string, string> aliasLines, string fileLoc)
        {
            fileLoc = "C:\\Users\\r_sod\\Documents\\Dungeons and Dragons Online\\ui\\layouts\\test.layout";
            //fileLoc = "C:\\Users\\r_sod\\Documents\\Dungeons and Dragons Online\\ui\\layouts\\bigscreen.layout";

            Aliases aliases = new Aliases();
            aliases.ScrubFile(fileLoc);
            aliases.WriteNewNodes(aliasLines, fileLoc);
        }
    }
}
