using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace DS_Gadget
{
    internal partial class GadgetTabStats : GadgetTab
    {
        public GadgetTabStats()
        {
            InitializeComponent();
        }

        public override void InitTab(MainForm parent)
        {
            base.InitTab(parent);
            MakeDicts();
            foreach (DSSex sex in DSSex.All)
                cmbSex.Items.Add(sex);
            foreach (DSClass charClass in DSClass.All)
                cmbClass.Items.Add(charClass);
            foreach (DSPhysique physique in DSPhysique.All)
                cmbPhysique.Items.Add(physique);
            nudHumanity.Maximum = int.MaxValue;
            nudHumanity.Minimum = int.MinValue;

            foreach (DSCovenant covenant in DSCovenant.All)
                cmbCovenant.Items.Add(covenant);
            ResetPage();
        }

        /// <summary>
        /// One init function to make all of the dictionaries
        /// </summary>
        private void MakeDicts()
        {
            //NudDict entries
            NudDict.Add(nudHumanity.Name, val => Hook.Humanity = val);
            NudDict.Add(nudSouls.Name, val => Hook.Souls = val);
            NudDict.Add(nudCovChaos.Name, val => Hook.ChaosServantPoints = (byte)val);
            NudDict.Add(nudCovDarkmoon.Name, val => Hook.DarkmoonBladePoints = (byte)val);
            NudDict.Add(nudCovDarkwraith.Name, val => Hook.DarkwraithPoints = (byte)val);
            NudDict.Add(nudCovForest.Name, val => Hook.ForestHunterPoints = (byte)val);
            NudDict.Add(nudCovGravelord.Name, val => Hook.GravelordServantPoints = (byte)val);
            NudDict.Add(nudCovDragon.Name, val => Hook.PathOfTheDragonPoints = (byte)val);
            NudDict.Add(nudCovSunlight.Name, val => Hook.WarriorOfSunlightPoints = (byte)val);

            //NudList
            NudList.Add(nudHumanity);
            NudList.Add(nudSouls);
            NudList.Add(nudVit);
            NudList.Add(nudAtt);
            NudList.Add(nudEnd);
            NudList.Add(nudStr);
            NudList.Add(nudDex);
            NudList.Add(nudRes);
            NudList.Add(nudInt);
            NudList.Add(nudFth);
            NudList.Add(nudCovChaos);
            NudList.Add(nudCovDarkmoon);
            NudList.Add(nudCovDarkwraith);
            NudList.Add(nudCovForest);
            NudList.Add(nudCovGravelord);
            NudList.Add(nudCovDragon);
            NudList.Add(nudCovSunlight);

            //CmbList
            CmbList.Add(cmbSex);
            CmbList.Add(cmbClass);
            CmbList.Add(cmbPhysique);
            CmbList.Add(cmbCovenant);

        }

        public override void ReloadTab()
        {
            txtName.Text = Hook.CharName;
            cmbSex.SelectedItem = cmbSex.Items.Cast<DSSex>().FirstOrDefault(s => s.ID == Hook.Sex);
            cmbClass.SelectedItem = cmbClass.Items.Cast<DSClass>().FirstOrDefault(c => c.ID == Hook.Class);
            cmbPhysique.SelectedItem = cmbPhysique.Items.Cast<DSPhysique>().FirstOrDefault(p => p.ID == Hook.Physique);
        }

        public override void UpdateTab()
        {
            txtSoulLevel.Text = Hook.SoulLevel.ToString();
            nudHumanity.Value = Hook.Humanity;
            nudSouls.Value = Hook.Souls;
            try
            {
                Updating = true;
                nudVit.Value = Hook.Vitality;
                nudAtt.Value = Hook.Attunement;
                nudEnd.Value = Hook.Endurance;
                nudStr.Value = Hook.Strength;
                nudDex.Value = Hook.Dexterity;
                nudRes.Value = Hook.Resistance;
                nudInt.Value = Hook.Intelligence;
                nudFth.Value = Hook.Faith;
                Updating = false;

            }
            // Race condition when checking if the game is still loaded; doesn't really matter
            catch (ArgumentOutOfRangeException) { }

            if (!cmbCovenant.DroppedDown)
            {
                cmbCovenant.SelectedItem = cmbCovenant.Items.Cast<DSCovenant>()
                    .FirstOrDefault(c => c.ID == Hook.Covenant);
            }
            nudCovChaos.Value = Hook.ChaosServantPoints;
            nudCovDarkmoon.Value = Hook.DarkmoonBladePoints;
            nudCovDarkwraith.Value = Hook.DarkwraithPoints;
            nudCovDragon.Value = Hook.PathOfTheDragonPoints;
            nudCovForest.Value = Hook.ForestHunterPoints;
            nudCovGravelord.Value = Hook.GravelordServantPoints;
            nudCovSunlight.Value = Hook.WarriorOfSunlightPoints;
        }

        private void RecalculateStats()
        {
            int vitality = (int)nudVit.Value;
            int attunement = (int)nudAtt.Value;
            int endurance = (int)nudEnd.Value;
            int strength = (int)nudStr.Value;
            int dexterity = (int)nudDex.Value;
            int resistance = (int)nudRes.Value;
            int intelligence = (int)nudInt.Value;
            int faith = (int)nudFth.Value;
            int sl = CalculateSL(vitality, attunement, endurance, strength, dexterity, resistance, intelligence, faith);

            Hook.LevelUp(vitality, attunement, endurance, strength, dexterity, resistance, intelligence, faith, sl);
        }

        private int CalculateSL(int vitality, int attunement, int endurance, int strength, int dexterity, int resistance, int intelligence, int faith)
        {
            DSClass charClass = cmbClass.SelectedItem as DSClass;
            int sl = charClass.SoulLevel;
            sl += vitality - charClass.Vitality;
            sl += attunement - charClass.Attunement;
            sl += endurance - charClass.Endurance;
            sl += strength - charClass.Strength;
            sl += dexterity - charClass.Dexterity;
            sl += resistance - charClass.Resistance;
            sl += intelligence - charClass.Intelligence;
            sl += faith - charClass.Faith;
            return sl;
        }

        internal void EnabledStats(bool enable)
        {
            if (enable)
            {

                if (cbxLoad.Checked)
                {
                    if (SavedStats.GetType().GetProperties().Select(pi => pi.GetValue(SavedStats) is Nullable).Any(value => value != null) || !string.IsNullOrWhiteSpace(SavedStats.Name))
                    {
                        UpdateTab();
                        LoadSavedStats();
                    }
                }
                CheckTextChange();
            }
            else
            {
                if (Main != null)
                {
                    ResetPage();
                }
            }
        }

        // Checks if the nuds value is null or not. Loads correct value if it is, and saves correct value if it isn't. Prevents numbers not showing up and not saving
        private void CheckTextChange()
        {
            if (nudHumanity.Text == "")
                nudHumanity.Text = Hook.Humanity.ToString();
            else
                SavedStats.Humanity = nudHumanity.Value;

            if (nudSouls.Text == "")
                nudSouls.Text = Hook.Souls.ToString();
            else
                SavedStats.Souls = nudSouls.Value;

            if (nudCovChaos.Text == "")
                nudCovChaos.Text = Hook.ChaosServantPoints.ToString();
            else
                SavedStats.CovChaos = nudCovChaos.Value;

            if (nudCovDarkmoon.Text == "")
                nudCovDarkmoon.Text = Hook.DarkmoonBladePoints.ToString();
            else
                SavedStats.CovDarkmoon = nudCovDarkmoon.Value;

            if (nudCovDarkwraith.Text == "")
                nudCovDarkwraith.Text = Hook.DarkwraithPoints.ToString();
            else
                SavedStats.CovDarkwraith = nudCovDarkwraith.Value;

            if (nudCovForest.Text == "")
                nudCovForest.Text = Hook.ForestHunterPoints.ToString();
            else
                SavedStats.CovForest = nudCovForest.Value;

            if (nudCovGravelord.Text == "")
                nudCovGravelord.Text = Hook.GravelordServantPoints.ToString();
            else
                SavedStats.CovGravelord = nudCovGravelord.Value;

            if (nudCovDragon.Text == "")
                nudCovDragon.Text = Hook.PathOfTheDragonPoints.ToString();
            else
                SavedStats.CovDragon = nudCovDragon.Value;

            if (nudCovSunlight.Text == "")
                nudCovSunlight.Text = Hook.WarriorOfSunlightPoints.ToString();
            else
                SavedStats.CovSunlight = nudCovSunlight.Value;

            if (nudVit.Text != "")
                SavedStats.Vit = nudVit.Value;
            if (nudAtt.Text != "")
                SavedStats.Att = nudAtt.Value;
            if (nudEnd.Text != "")
                SavedStats.End = nudEnd.Value;
            if (nudStr.Text != "")
                SavedStats.Str = nudStr.Value;
            if (nudDex.Text != "")
                SavedStats.Dex = nudDex.Value;
            if (nudRes.Text != "")
                SavedStats.Res = nudRes.Value;
            if (nudInt.Text != "")
                SavedStats.Int = nudInt.Value;
            if (nudFth.Text != "")
                SavedStats.Fth = nudFth.Value;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!Reading)
            {
                if (Hook.Loaded)
                {
                    Hook.CharName = txtName.Text;
                }
                else
                {
                    SavedStats.Name = txtName.Text;
                }
            }

        }

        private void cmbSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSex.SelectedIndex != -1)
            {
                if (!Reading)
                {
                    if (Hook.Loaded)
                    {
                        Hook.Sex = (cmbSex.SelectedItem as DSSex).ID;
                    }
                    else
                    {
                        SaveStatsCmb(sender);
                    }
                }
            }
            
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClass.SelectedIndex != -1)
            {
                DSClass charClass = cmbClass.SelectedItem as DSClass;
                if (Hook.Loaded)
                {
                    nudVit.Minimum = charClass.Vitality;
                    nudAtt.Minimum = charClass.Attunement;
                    nudEnd.Minimum = charClass.Endurance;
                    nudStr.Minimum = charClass.Strength;
                    nudDex.Minimum = charClass.Dexterity;
                    nudRes.Minimum = charClass.Resistance;
                    nudInt.Minimum = charClass.Intelligence;
                    nudFth.Minimum = charClass.Faith;
                }

                if (!Reading)
                {
                    if (Hook.Loaded)
                    {
                        Hook.Class = charClass.ID;
                        RecalculateStats();
                    }
                    else
                    {
                        SaveStatsCmb(sender);
                    }

                }
            }
        }

        private void cmbPhysique_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPhysique.SelectedIndex != -1)
            {
                if (!Reading)
                {
                    if (Hook.Loaded)
                    {
                        Hook.Physique = (cmbPhysique.SelectedItem as DSPhysique).ID;
                    }
                    else
                    {
                        SaveStatsCmb(sender);
                    }
                }
            }
            
        }

        private SavedStats SavedStats = new SavedStats();

        public bool Updating { get; private set; }

        private void nudStat_ValueChanged(object sender, EventArgs e)
        {
            if (!Reading)
            {
                if(Hook.Loaded)
                {
                    if (!Updating)
                    {
                        RecalculateStats();
                    }
                }
                else
                {
                    SaveStatsNud(sender);

                    if (cmbClass.SelectedIndex == -1)
                    {
                        txtSoulLevel.Text = (nudVit.Value + nudAtt.Value + nudEnd.Value + nudStr.Value + nudDex.Value + nudRes.Value + nudInt.Value + nudFth.Value).ToString();
                    }
                    else
                    {
                        txtSoulLevel.Text = CalculateSL((int)nudVit.Value, (int)nudAtt.Value, (int)nudEnd.Value, (int)nudStr.Value, (int)nudDex.Value, (int)nudRes.Value, (int)nudInt.Value, (int)nudFth.Value).ToString();
                    }
                }
            }
        }
        
        // Takes Sender as NumericUpDown and retrieves set Action from StatsDict
        private void SaveStatsNud(object sender)
        {
            var nud = sender as NumericUpDown;
            SavedStats[nud.Name] = nud.Value;
            nud.Text = nud.Value.ToString(); //Update the text incase the value was the same as the previous value
        }

        private void SaveStatsCmb(object sender)
        {
            var cmb = sender as ComboBox;
            SavedStats[cmb.Name] = cmb.SelectedIndex;
        }

        private void cmbCovenant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCovenant.SelectedIndex != -1)
            {
                if (!Reading)
                {
                    if (Hook.Loaded)
                    {
                        Hook.Covenant = ((DSCovenant)cmbCovenant.SelectedItem).ID;
                    }
                    else
                    {
                        SaveStatsCmb(sender);
                    }
                }
            }
        }

        //Dictionary that contains all of the Nuds and their corresponding Hook property (Except stats, as they are handled by their own method)
        private Dictionary<string, Action<int>> NudDict = new Dictionary<string, Action<int>>();

        private void nud_ValueChanged(object sender, EventArgs e)
        {
            if (!Reading)
            {
                var nud = sender as NumericUpDown;
                if (Hook.Loaded)
                {
                    NudDict[nud.Name].Invoke((int)nud.Value);
                }
                else
                {
                    SaveStatsNud(sender);
                }
            }
        }

        public static decimal Clamp(decimal value, decimal min, decimal max)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }

        private List<NumericUpDown> NudList = new List<NumericUpDown>();

        private List<ComboBox> CmbList = new List<ComboBox>();

        //Check each saved stat if it's null and load them if they aren't
        private void LoadSavedStats()
        {
            if (Hook.Loaded)
            {
                if (!string.IsNullOrWhiteSpace(SavedStats.Name))
                {
                    txtName.Text = SavedStats.Name;
                }

                foreach (var nud in NudList)
                {
                    var stat = (decimal?)SavedStats[nud.Name];
                    if (stat.HasValue)
                    {
                        nud.Value = Clamp(stat.Value, nud.Minimum, nud.Maximum);
                    }
                        
                }

                foreach (var cmb in CmbList)
                {
                    var index = (int?)SavedStats[cmb.Name];
                    if (index.HasValue)
                    {
                        cmb.SelectedIndex = index.Value;
                    }
                }
            }
        }

        // Resets all values on page to a blank state in order of the SavedStats class
        private void ResetPage()
        {
            txtName.Text = null;
            SavedStats.Name = null;
            NullCMB(cmbSex);
            NullCMB(cmbClass);
            NullCMB(cmbPhysique);
            NullNUD(nudHumanity);
            NullNUD(nudSouls);
            NullNUD(nudVit);
            NullNUD(nudAtt);
            NullNUD(nudEnd);
            NullNUD(nudStr);
            NullNUD(nudDex);
            NullNUD(nudRes);
            NullNUD(nudInt);
            NullNUD(nudFth);
            NullCMB(cmbCovenant);
            NullNUD(nudCovChaos);
            NullNUD(nudCovDarkmoon);
            NullNUD(nudCovDarkwraith);
            NullNUD(nudCovForest);
            NullNUD(nudCovGravelord);
            NullNUD(nudCovDragon);
            NullNUD(nudCovSunlight);
        }

        
        private void nudKeyDown(object sender, KeyEventArgs e)
        {
            if (!Hook.Loaded)
            {
                //If Enter Save stats
                if (e.KeyCode == Keys.Enter)
                {
                    SaveStatsNud(sender);
                }

                //If Escape Null stats
                if (e.KeyCode == Keys.Escape)
                {
                    NullNUD(sender);
                }
            }
        }

        //Switch that nulls out nuds and their associated SavedStat
        private void NullNUD(object sender)
        {
            var stat = sender as NumericUpDown;
            if (stat.Minimum > 0)
                stat.Minimum = 0;
            stat.Value = 0;
            stat.Text = "";
            SavedStats[stat.Name] = null;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Hook.Loaded)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    txtName.Text = null;
                    SavedStats.Name = null;
                }
            }
        }

        private void cmbKeyDown(object sender, KeyEventArgs e)
        {
            if (!Hook.Loaded)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    NullCMB(sender);
                }
            }
        }

        //Switch that nulls out combo boxes and their associated SavedStat
        private void NullCMB(object sender)
        {
            var cmb = sender as ComboBox;
            cmb.SelectedIndex = -1;
            SavedStats[cmb.Name] = null;
        }
    }
}
