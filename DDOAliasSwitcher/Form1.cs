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
                Aliases aliases = new Aliases();
                AliasCount = aliases.GetSectionCount("Colors");
                counterLabel.Text = Convert.ToString(AliasCount);

                // Update the form with any settings the user previously used
                if (!string.IsNullOrEmpty(UserSettings.Default.LayoutFileLocation))
                {
                    locTextBox.Text = UserSettings.Default.LayoutFileLocation;
                }
                if (!string.IsNullOrEmpty(UserSettings.Default.DefaultRaidDay))
                {
                    raidDayComboBox.Text = UserSettings.Default.DefaultRaidDay;
                    raidDayComboBox.SelectedValue = UserSettings.Default.DefaultRaidDay;
                }
                ahkCheckbox.Checked = UserSettings.Default.RunAHK;
            }
            catch
            {
                AliasCount = 0; // Something happened to the colors section? Set to 0 and move on.

                // Do nothing, failure here will simply not save a user's settings
                // for their next session. No biggie, just a little annoying.
            }
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
                    if (raidDayComboBox.SelectedIndex >= 0 && raidDayComboBox.Text != "-----")
                    {
                        string raidDay = raidDayComboBox.Text;

                        try
                        {
                            // Save user's most recent layout file settings
                            if (locTextBox.Text != UserSettings.Default.LayoutFileLocation)
                            {
                                UserSettings.Default.LayoutFileLocation = locTextBox.Text;
                            }
                            if (raidDayComboBox.Text != UserSettings.Default.DefaultRaidDay)
                            {
                                UserSettings.Default.DefaultRaidDay = raidDayComboBox.Text;
                            }
                            UserSettings.Default.RunAHK = ahkCheckbox.Checked;

                            UserSettings.Default.Save();

                            // Generate the DASLayout.layout file for use by application and script
                            string dir = Path.GetDirectoryName(locTextBox.Text);

                            string DASLayoutLoc = $"{dir}\\DASLayout.layout";
                            File.Copy(locTextBox.Text, DASLayoutLoc, true);

                            ProvideFileInfo(raidDay, DASLayoutLoc);

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
                        MessageBox.Show("Please use the dropdown to choose your alias settings.",
                            "Missing values", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Please search or enter your layout file location in the \"Where is your Layout File?\" field.",
                        "Missing values", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void ProvideFileInfo(string raidDay, string fileLoc)
        {
            LayoutBuilder layout = new LayoutBuilder();
            Aliases alias = new Aliases();

            Dictionary<string, string> aliasLines = new Dictionary<string, string>();

            if (raidDay == "MyDefaultFile")
                aliasLines = alias.CompileFromDefaultFile(locTextBox.Text);
            else
                aliasLines = alias.CompileForRaidDay(raidDay);

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
        private void chronoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("Chronoscope");

            if (chronoCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!chronoCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void shroudCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("CodexAndTheShroud");

            if (shroudCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!shroudCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void strahdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("CurseOfStrahd");

            if (strahdCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!strahdCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void dojCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("DefilerOfTheJust");

            if (dojCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!dojCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void dryadCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("DryadAndTheDemigod");

            if (dryadCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!dryadCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void fotCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("FallOfTruth");

            if (fotCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!fotCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void fotpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("FireOnThunderPeak");

            if (fotpCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!fotpCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void hoxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("HoundOfXoriat");

            if (hoxCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!hoxCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void huntCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("HuntOrBeHunted");

            if (huntCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!huntCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void ktCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("KillingTime");

            if (ktCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!ktCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void lobCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("LordOfBlades");

            if (lobCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!lobCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void modCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("MarkOfDeath");

            if (modCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!modCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void maCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("MasterArtificer");

            if (maCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!maCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void babaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("OldBabasHut");

            if (babaCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!babaCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void ponCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("PlaneOfNight");

            if (ponCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!ponCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void pnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("ProjectNemesis");

            if (pnCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!pnCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void rtsoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("RidingTheStormOut");

            if (rtsoCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!rtsoCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void skelesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("SkeletonsInTheCloset");

            if (skelesCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!skelesCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void skelesTalkCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("SkeletonsTalkingOpt");

            if (skelesTalkCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!skelesTalkCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void deathwyrmCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("TempleOfDeathwyrm");

            if (deathwyrmCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!deathwyrmCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void ththCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("TooHotToHandle");

            if (ththCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!ththCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void vodCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("VisionOfDestruction");

            if (vodCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!vodCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void vonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("VaultOfNight");

            if (vonCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!vonCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void zrCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Aliases aliases = new Aliases();
            int counter = aliases.GetSectionCount("ZawabisRevenge");

            if (zrCheckBox.Checked)
            {
                IncreaseCounter(counter);
            }
            if (!zrCheckBox.Checked)
            {
                DecreaseCounter(counter);
            }
        }

        private void defaultCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Handle this so none of the others can be checked at the same time
            // (Uncheck others?)
        }
        #endregion

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