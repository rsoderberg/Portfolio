using System.Collections.Specialized;
using System.Configuration;

namespace DDOAliasSwitcher
{
    public partial class Form1 : Form
    {
        private int AliasCount { get; set; }

        public Form1()
        {
            InitializeComponent();

            try
            {
                GetColorSectionCount();
                counterLabel.Text = Convert.ToString(AliasCount);

                ApplyUserSettings();
            }
            catch
            {
                if (string.IsNullOrEmpty(Convert.ToString(AliasCount))) // Something happened to the colors section? Set to 0 and move on.
                    AliasCount = 0;

                // Do nothing, failure here will simply not save a user's settings
                // for their next session. No biggie, just a little annoying.
            }
        }

        /// <summary>
        /// Update the form with settings from UserSettings.settings file
        /// </summary>
        private void ApplyUserSettings()
        {
            if (!string.IsNullOrEmpty(UserSettings.Default.LayoutFileLocation))
            {
                locTextBox.Text = UserSettings.Default.LayoutFileLocation;
            }
            ahkCheckbox.Checked = UserSettings.Default.RunAHK;
            ChronoscopeCheckBox.Checked = UserSettings.Default.Chronoscope;
            CodexAndTheShroudCheckBox.Checked = UserSettings.Default.CodexAndTheShroud;
            CurseOfStrahdCheckBox.Checked = UserSettings.Default.CodexAndTheShroud;
            DefilerOfTheJustCheckBox.Checked = UserSettings.Default.DefilerOfTheJust;
            DryadAndTheDemigodCheckBox.Checked = UserSettings.Default.DryadAndTheDemigod;
            FallOfTruthCheckBox.Checked = UserSettings.Default.FallOfTruth;
            FireOnThunderPeakCheckBox.Checked = UserSettings.Default.FireOnThunderPeak;
            HoundOfXoriatCheckBox.Checked = UserSettings.Default.HoundOfXoriat;
            KillingTimeCheckBox.Checked = UserSettings.Default.KillingTime;
            LordOfBladesCheckBox.Checked = UserSettings.Default.LordOfBlades;
            MarkOfDeathCheckBox.Checked = UserSettings.Default.MarkOfDeath;
            MasterArtificerCheckBox.Checked = UserSettings.Default.MasterArtificer;
            OldBabasHutCheckBox.Checked = UserSettings.Default.OldBabasHut;
            ProjectNemesisCheckBox.Checked = UserSettings.Default.ProjectNemesis;
            RidingTheStormOutCheckBox.Checked = UserSettings.Default.RidingTheStormOut;
            SkeletonsInTheClosetCheckBox.Checked = UserSettings.Default.SkeletonsInTheCloset;
            TempleOfDeathwyrmCheckBox.Checked = UserSettings.Default.TempleOfDeathwyrm;
            TooHotToHandleCheckBox.Checked = UserSettings.Default.TooHotToHandle;
            VaultOfNightCheckBox.Checked = UserSettings.Default.VaultOfNight;
            VisionOfDestructionCheckBox.Checked = UserSettings.Default.VisionOfDestruction;
            ZawabisRevengeCheckBox.Checked = UserSettings.Default.ZawabisRevenge;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (AliasCount > 50)
            {
                MessageBox.Show("You are using more than 50 aliases and DDO will be very sad :(",
                    "Over Alias Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (!string.IsNullOrEmpty(locTextBox.Text))
                {
                    if (AnyRaidChecked())
                    {
                        try
                        {
                            // Save user's most recent layout file settings
                            if (locTextBox.Text != UserSettings.Default.LayoutFileLocation)
                            {
                                UserSettings.Default.LayoutFileLocation = locTextBox.Text;
                            }
                            UserSettings.Default.RunAHK = ahkCheckbox.Checked;
                            UserSettings.Default.Save();

                            // Generate the DASLayout.layout file for use by application and script
                            string dir = Path.GetDirectoryName(locTextBox.Text);

                            string DASLayoutLoc = $"{dir}\\DASLayout.layout";
                            File.Copy(locTextBox.Text, DASLayoutLoc, true);

                            ProvideFileInfo(RaidSelections(), DASLayoutLoc);

                            if (ahkCheckbox.Checked)
                            {
                                AHK ahk = new AHK();
                                ahk.ReloadLayoutInDDO();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check one of the raids to choose your alias settings.",
                            "Missing Raid Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Please search or enter your layout file location in the \"Where is your Layout File?\" field.",
                        "Missing values", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private List<string> RaidSelections()
        {
            List<string> raidList = new List<string>();

            foreach (Control c in raidsGroupBox.Controls)
            {
                CheckBox ? checkbox = c as CheckBox;
                if (checkbox != null && checkbox.Checked)
                {
                    raidList.Add(checkbox.Name);
                }
            }

            return raidList;
        }

        private bool AnyRaidChecked()
        {
            foreach (Control c in raidsGroupBox.Controls)
            {
                CheckBox? checkbox = c as CheckBox;
                if (checkbox != null && checkbox.Checked)
                {
                    return true;
                }
            }

            return false;
        }

        private void ProvideFileInfo(List<string> raidSelection, string fileLoc)
        {
            LayoutBuilder layout = new LayoutBuilder();
            Aliases alias = new Aliases();

            Dictionary<string, string> aliasLines = new Dictionary<string, string>();

            if (raidSelection[0] == "DefaultCheckBox")
                aliasLines = alias.CompileFromDefaultFile(locTextBox.Text);
            else
                aliasLines = alias.CompileRaids(raidSelection);

            layout.EditXMLForRaidDay(aliasLines, fileLoc);
        }

        private void locButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Layout Files (*.layout)|*.layout";
            dlg.FilterIndex = 1;
            dlg.InitialDirectory = "C:\\..\\Dungeons and Dragons Online\\ui\\layouts";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                locTextBox.Text = dlg.FileName;
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        #region Raid Checkboxes
        private void ChronoscopeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetSectionCount("Chronoscope", ChronoscopeCheckBox.Checked);
        }

        private void CodexAndTheShroudCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetSectionCount("CodexAndTheShroud", CodexAndTheShroudCheckBox.Checked);
        }

        private void CurseOfStrahdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetSectionCount("CurseOfStrahd", CurseOfStrahdCheckBox.Checked);
        }

        private void DefilerOfTheJustCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetSectionCount("DefilerOfTheJust", DefilerOfTheJustCheckBox.Checked);
        }

        private void DryadAndTheDemigodCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetSectionCount("DryadAndTheDemigod", DryadAndTheDemigodCheckBox.Checked);
        }

        private void FallOfTruthCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetSectionCount("FallOfTruth", FallOfTruthCheckBox.Checked);
        }

        private void FireOnThunderPeakCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetSectionCount("FireOnThunderPeak", FireOnThunderPeakCheckBox.Checked);
        }

        private void HoundOfXoriatCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetSectionCount("HoundOfXoriat", HoundOfXoriatCheckBox.Checked);
        }

        private void HuntOrBeHuntedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetSectionCount("HuntOrBeHunted", HuntOrBeHuntedCheckBox.Checked);
        }

        private void KillingTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetSectionCount("KillingTime", KillingTimeCheckBox.Checked);
        }

        private void LordOfBladesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetSectionCount("LordOfBlades", LordOfBladesCheckBox.Checked);
        }

        private void MarkOfDeathCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetSectionCount("MarkOfDeath", MarkOfDeathCheckBox.Checked);
        }

        private void MasterArtificerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetSectionCount("MasterArtificer", MasterArtificerCheckBox.Checked);
        }

        private void OldBabasHutCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetSectionCount("OldBabasHut", OldBabasHutCheckBox.Checked);
        }

        private void ProjectNemesisCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetSectionCount("ProjectNemesis", ProjectNemesisCheckBox.Checked);
        }

        private void RidingTheStormOutCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetSectionCount("RidingTheStormOut", RidingTheStormOutCheckBox.Checked);
        }

        private void SkeletonsInTheClosetCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetSectionCount("SkeletonsInTheCloset", SkeletonsInTheClosetCheckBox.Checked);
        }

        private void SkeletonsTalkingOptCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetSectionCount("SkeletonsTalkingOpt", SkeletonsTalkingOptCheckBox.Checked);
        }

        private void TempleOfDeathwyrmCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetSectionCount("TempleOfDeathwyrm", TempleOfDeathwyrmCheckBox.Checked);
        }

        private void TooHotToHandleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetSectionCount("TooHotToHandle", TooHotToHandleCheckBox.Checked);
        }

        private void VisionOfDestructionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetSectionCount("VisionOfDestruction", VisionOfDestructionCheckBox.Checked);
        }

        private void VaultOfNightCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetSectionCount("VaultOfNight", VaultOfNightCheckBox.Checked);
        }

        private void ZawabisRevengeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GetSectionCount("ZawabisRevenge", ZawabisRevengeCheckBox.Checked);
        }

        private void DefaultCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control c in raidsGroupBox.Controls)
            {
                CheckBox? checkbox = c as CheckBox;
                if (checkbox.Name != "DefaultCheckBox" && checkbox != null && checkbox.Checked)
                {
                    checkbox.Checked = false;
                }
            }
        }
        #endregion

        private void GetColorSectionCount()
        {
            NameValueCollection section = (NameValueCollection)ConfigurationManager.GetSection("Colors");

            int sectionCount = 1; // Account for ;list alias

            if (section.Count > 0)
            {
                sectionCount = section.Count;
            }

            AliasCount = sectionCount;
        }

        private void GetSectionCount(string sectionName, bool boxChecked)
        {
            NameValueCollection section = (NameValueCollection)ConfigurationManager.GetSection(sectionName);

            int sectionCount = 0;

            if (section.Count > 0)
            {
                sectionCount = section.Count;
            }

            if (boxChecked)
            {
                IncreaseCounter(sectionCount);
            }
            if (!boxChecked)
            {
                DecreaseCounter(sectionCount);
            }
        }

        private void IncreaseCounter(int counter)
        {
            AliasCount += counter;
            counterLabel.Text = Convert.ToString(AliasCount);

            if (AliasCount >= 50)
                counterLabel.ForeColor = Color.Red;
        }

        private void DecreaseCounter(int counter)
        {
            AliasCount -= counter;
            counterLabel.Text = Convert.ToString(AliasCount);

            if (AliasCount < 50)
                counterLabel.ForeColor = Color.Black;
        }
    }
}