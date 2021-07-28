using System;
using System.Linq;

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
                nudVit.Value = Hook.Vitality;
                nudAtt.Value = Hook.Attunement;
                nudEnd.Value = Hook.Endurance;
                nudStr.Value = Hook.Strength;
                nudDex.Value = Hook.Dexterity;
                nudRes.Value = Hook.Resistance;
                nudInt.Value = Hook.Intelligence;
                nudFth.Value = Hook.Faith;
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
                if (SavedStats.GetType().GetProperties().Select(pi => pi.GetValue(SavedStats)).Any(value => value != null))
                {
                    gbxLoadStats.Visible = true;
                }
            }
            else
            {
                gbxLoadStats.Visible = false;
                if (Main != null)
                {
                    ResetPage();
                }
            }
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
                        SavedStats.Sex = cmbSex.SelectedIndex;
                    }
                }
            }
            
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClass.SelectedIndex != -1)
            {
                DSClass charClass = cmbClass.SelectedItem as DSClass;
                nudVit.Minimum = charClass.Vitality;
                nudAtt.Minimum = charClass.Attunement;
                nudEnd.Minimum = charClass.Endurance;
                nudStr.Minimum = charClass.Strength;
                nudDex.Minimum = charClass.Dexterity;
                nudRes.Minimum = charClass.Resistance;
                nudInt.Minimum = charClass.Intelligence;
                nudFth.Minimum = charClass.Faith;
                if (!Reading)
                {
                    if (Hook.Loaded)
                    {
                        Hook.Class = charClass.ID;
                        RecalculateStats();
                    }
                    else
                    {
                        SavedStats.Class = cmbClass.SelectedIndex;
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
                        SavedStats.Physique = cmbPhysique.SelectedIndex;
                    }
                }
            }
            
        }

        private void nudHumanity_ValueChanged(object sender, EventArgs e)
        {
            if (!Reading)
            {
                if (Hook.Loaded)
                {
                    Hook.Humanity = (int)nudHumanity.Value;
                }
                else
                {
                    SavedStats.Humanity = nudHumanity.Value;
                }
            }
        }

        private void nudSouls_ValueChanged(object sender, EventArgs e)
        {
            if (!Reading)
            {
                if (Hook.Loaded)
                {
                    Hook.Souls = (int)nudSouls.Value;
                }
                else
                {
                    SavedStats.Souls = nudSouls.Value;
                }
            }
        }

        private SavedStats SavedStats = new SavedStats();

        private void nudStat_ValueChanged(object sender, EventArgs e)
        {
            if (!Reading)
            {
                if(Hook.Loaded)
                {
                    RecalculateStats();
                }
                else
                {
                    SaveStats(sender);

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

        private void SaveStats(object sender)
        {
            var stat = sender as System.Windows.Forms.NumericUpDown;
            switch (stat.Name)
            {
                case "nudVit":
                    SavedStats.Vit = nudVit.Value;
                    break;
                case "nudAtt":
                    SavedStats.Att = nudAtt.Value;
                    break;
                case "nudEnd":
                    SavedStats.End = nudEnd.Value;
                    break;
                case "nudStr":
                    SavedStats.Str = nudStr.Value;
                    break;
                case "nudDex":
                    SavedStats.Dex = nudDex.Value;
                    break;
                case "nudRes":
                    SavedStats.Res = nudRes.Value;
                    break;
                case "nudInt":
                    SavedStats.Int = nudInt.Value;
                    break;
                case "nudFth":
                    SavedStats.Fth = nudFth.Value;
                    break;
                default:
                    break;
            }
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
                        SavedStats.Covenant = cmbCovenant.SelectedIndex;
                    }
                }
            }
            
                
        }

        private void nudCovChaos_ValueChanged(object sender, EventArgs e)
        {
            if (!Reading)
            {
                if (Hook.Loaded)
                {
                    Hook.ChaosServantPoints = (byte)nudCovChaos.Value;
                }
                else
                {
                    SavedStats.CovChaos = nudCovChaos.Value;
                }
            }
                
        }

        private void nudCovDarkmoon_ValueChanged(object sender, EventArgs e)
        {
            if (!Reading)
            {
                if (Hook.Loaded)
                {
                    Hook.DarkmoonBladePoints = (byte)nudCovDarkmoon.Value;
                }
                else
                {
                    SavedStats.CovDarkmoon = nudCovDarkmoon.Value;
                }
            }
                
        }

        private void nudCovDarkwraith_ValueChanged(object sender, EventArgs e)
        {
            if (!Reading)
            {
                if (Hook.Loaded)
                {
                    Hook.DarkwraithPoints = (byte)nudCovDarkwraith.Value;
                }
                else
                {
                    SavedStats.CovDarkwraith = nudCovDarkwraith.Value;
                }
            }
                
        }

        private void nudCovForest_ValueChanged(object sender, EventArgs e)
        {
            if (!Reading)
            {
                if (Hook.Loaded)
                {
                    Hook.ForestHunterPoints = (byte)nudCovForest.Value;
                }
                else
                {
                    SavedStats.CovForest = nudCovForest.Value;
                }
            }
                
        }

        private void nudCovGravelord_ValueChanged(object sender, EventArgs e)
        {
            if (!Reading)
            {
                if (Hook.Loaded)
                {
                    Hook.GravelordServantPoints = (byte)nudCovGravelord.Value;
                }
                else
                {
                    SavedStats.CovGravelord = nudCovGravelord.Value;
                }
            }
                
        }

        private void nudCovDragon_ValueChanged(object sender, EventArgs e)
        {
            if (!Reading)
            {
                if (Hook.Loaded)
                {
                    Hook.PathOfTheDragonPoints = (byte)nudCovDragon.Value;
                }
                else
                {
                    SavedStats.CovDragon = nudCovDragon.Value;
                }
            }
                
        }

        private void nudCovSunlight_ValueChanged(object sender, EventArgs e)
        {
            if (!Reading)
            {
                if (Hook.Loaded)
                {
                    Hook.WarriorOfSunlightPoints = (byte)nudCovSunlight.Value;
                }
                else
                {
                    SavedStats.CovSunlight = nudCovSunlight.Value;
                }
            }

        }

        public static decimal Clamp(decimal value, decimal min, decimal max)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }

        private void LoadSavedStats()
        {
            if (Hook.Loaded)
            {
                if (!string.IsNullOrWhiteSpace(SavedStats.Name))
                {
                    txtName.Text = SavedStats.Name;
                }

                if (SavedStats.Sex.HasValue)
                {
                    cmbSex.SelectedIndex = SavedStats.Sex.Value;
                }

                if (SavedStats.Class.HasValue)
                {
                    cmbClass.SelectedIndex = SavedStats.Class.Value;
                }

                if (SavedStats.Physique.HasValue)
                {
                    cmbPhysique.SelectedIndex = SavedStats.Physique.Value;
                }

                if (SavedStats.Humanity.HasValue)
                {
                    nudHumanity.Value = SavedStats.Humanity.Value;
                }

                if (SavedStats.Souls.HasValue)
                {
                    nudSouls.Value = SavedStats.Souls.Value;
                }

                if (SavedStats.Vit.HasValue)
                {
                    nudVit.Value = Clamp(SavedStats.Vit.Value, nudVit.Minimum, nudVit.Maximum);
                }

                if (SavedStats.Att.HasValue)
                {
                    nudAtt.Value = Clamp(SavedStats.Att.Value, nudAtt.Minimum, nudAtt.Maximum);
                }

                if (SavedStats.End.HasValue)
                {
                    nudEnd.Value = Clamp(SavedStats.End.Value, nudEnd.Minimum, nudEnd.Maximum);
                }

                if (SavedStats.Str.HasValue)
                {
                    nudStr.Value = Clamp(SavedStats.Str.Value, nudStr.Minimum, nudStr.Maximum);
                }

                if (SavedStats.Dex.HasValue)
                {
                    nudDex.Value = Clamp(SavedStats.Dex.Value, nudDex.Minimum, nudDex.Maximum);
                }

                if (SavedStats.Res.HasValue)
                {
                    nudRes.Value = Clamp(SavedStats.Res.Value, nudRes.Minimum, nudRes.Maximum);
                }

                if (SavedStats.Int.HasValue)
                {
                    nudInt.Value = Clamp(SavedStats.Int.Value, nudInt.Minimum, nudInt.Maximum);
                }

                if (SavedStats.Fth.HasValue)
                {
                    nudFth.Value = Clamp(SavedStats.Fth.Value, nudFth.Minimum, nudFth.Maximum);
                }

                if (SavedStats.Covenant.HasValue)
                {
                    cmbCovenant.SelectedIndex = SavedStats.Covenant.Value;
                }

                if (SavedStats.CovChaos.HasValue)
                {
                    nudCovChaos.Value = SavedStats.CovChaos.Value;
                }

                if (SavedStats.CovDarkmoon.HasValue)
                {
                    nudCovDarkmoon.Value = SavedStats.CovDarkmoon.Value;
                }

                if (SavedStats.CovDarkwraith.HasValue)
                {
                    nudCovDarkwraith.Value = SavedStats.CovDarkwraith.Value;
                }

                if (SavedStats.CovForest.HasValue)
                {
                    nudCovForest.Value = SavedStats.CovForest.Value;
                }

                if (SavedStats.CovGravelord.HasValue)
                {
                    nudCovGravelord.Value = SavedStats.CovGravelord.Value;
                }

                if (SavedStats.CovDragon.HasValue)
                {
                    nudCovDragon.Value = SavedStats.CovDragon.Value;
                }

                if (SavedStats.CovSunlight.HasValue)
                {
                    nudCovSunlight.Value = SavedStats.CovSunlight.Value;
                }
            }

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            LoadSavedStats();
            gbxLoadStats.Visible = false;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            gbxLoadStats.Visible = false;
        }

        private void ResetPage()
        {
            txtName.Text = null;
            cmbSex.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbPhysique.SelectedIndex = -1;
            nudHumanity.Value = 0;
            nudSouls.Value = 0;
            txtSoulLevel.Text = "";
            nudVit.Minimum = 0;
            nudVit.Value = 0;
            nudAtt.Minimum = 0;
            nudAtt.Value = 0;
            nudEnd.Minimum = 0;
            nudEnd.Value = 0;
            nudStr.Minimum = 0;
            nudStr.Value = 0;
            nudDex.Minimum = 0;
            nudDex.Value = 0;
            nudRes.Minimum = 0;
            nudRes.Value = 0;
            nudInt.Minimum = 0;
            nudInt.Value = 0;
            nudFth.Minimum = 0;
            nudFth.Value = 0;
            cmbCovenant.SelectedIndex = -1;
            nudCovChaos.Value = 0;
            nudCovDarkmoon.Value = 0;
            nudCovDarkwraith.Value = 0;
            nudCovForest.Value = 0;
            nudCovGravelord.Value = 0;
            nudCovDragon.Value = 0;
            nudCovSunlight.Value = 0;
            SavedStats = new SavedStats();
        }

        private void nudKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (!Hook.Loaded)
            {
                if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                {
                    SaveStats(sender);
                    var stat = sender as System.Windows.Forms.NumericUpDown;
                    switch (stat.Name)
                    {
                        case "nudHumanity":
                            SavedStats.Humanity = nudHumanity.Value;
                            break;
                        case "nudSouls":
                            SavedStats.Souls = nudSouls.Value;
                            break;
                        case "nudCovChaos":
                            SavedStats.CovChaos = nudCovChaos.Value;
                            break;
                        case "nudCovDarkmoon":
                            SavedStats.CovDarkmoon = nudCovDarkmoon.Value;
                            break;
                        case "nudCovDarkwraith":
                            SavedStats.CovDarkwraith = nudCovDarkwraith.Value;
                            break;
                        case "nudCovForest":
                            SavedStats.CovForest = nudCovForest.Value;
                            break;
                        case "nudCovGravelord":
                            SavedStats.CovGravelord = nudCovGravelord.Value;
                            break;
                        case "nudCovDragon":
                            SavedStats.CovDragon = nudCovDragon.Value;
                            break;
                        case "nudCovSunlight":
                            SavedStats.CovSunlight = nudCovSunlight.Value;
                            break;
                        default:
                            break;
                    }
                    
                }

                if (e.KeyCode == System.Windows.Forms.Keys.Escape)
                {
                    var stat = sender as System.Windows.Forms.NumericUpDown;
                    switch (stat.Name)
                    {
                        case "nudHumanity":
                            nudHumanity.Value = 0;
                            SavedStats.Humanity = null;
                            break;
                        case "nudSouls":
                            nudSouls.Value = 0;
                            SavedStats.Souls = null;
                            break;
                        case "nudVit":
                            nudVit.Value = 0;
                            SavedStats.Vit = null;
                            break;
                        case "nudAtt":
                            nudAtt.Value = 0;
                            SavedStats.Att = null;
                            break;
                        case "nudEnd":
                            nudEnd.Value = 0;
                            SavedStats.End = null;
                            break;
                        case "nudStr":
                            nudStr.Value = 0;
                            SavedStats.Str = null;
                            break;
                        case "nudDex":
                            nudDex.Value = 0;
                            SavedStats.Dex = null;
                            break;
                        case "nudRes":
                            nudRes.Value = 0;
                            SavedStats.Res = null;
                            break;
                        case "nudInt":
                            nudInt.Value = 0;
                            SavedStats.Int = null;
                            break;
                        case "nudFth":
                            nudFth.Value = 0;
                            SavedStats.Fth = null;
                            break;
                        case "nudCovChaos":
                            nudCovChaos.Value = 0;
                            SavedStats.CovChaos = null;
                            break;
                        case "nudCovDarkmoon":
                            nudCovDarkmoon.Value = 0;
                            SavedStats.CovDarkmoon = null;
                            break;
                        case "nudCovDarkwraith":
                            nudCovDarkwraith.Value = 0;
                            SavedStats.CovDarkwraith = null;
                            break;
                        case "nudCovForest":
                            nudCovForest.Value = 0;
                            SavedStats.CovForest = null;
                            break;
                        case "nudCovGravelord":
                            nudCovGravelord.Value = 0;
                            SavedStats.CovGravelord = null;
                            break;
                        case "nudCovDragon":
                            nudCovDragon.Value = 0;
                            SavedStats.CovDragon = null;
                            break;
                        case "nudCovSunlight":
                            nudCovSunlight.Value = 0;
                            SavedStats.CovSunlight = null;
                            break;
                        default:
                            break;
                    }
                }
            }

        }

        private void txtName_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if(!Hook.Loaded)
            {
                if (e.KeyCode == System.Windows.Forms.Keys.Escape)
                {
                    txtName.Text = null;
                    SavedStats.Name = null;
                }
            }
            
        }

        private void cmbKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (!Hook.Loaded)
            {
                if (e.KeyCode == System.Windows.Forms.Keys.Escape)
                {
                    var cmb = sender as System.Windows.Forms.ComboBox;
                    switch (cmb.Name)
                    {
                        case "cmbSex":
                            cmbSex.SelectedIndex = -1;
                            SavedStats.Sex = null;
                            break;
                        case "cmbClass":
                            cmbClass.SelectedIndex = -1;
                            SavedStats.Class = null;
                            break;
                        case "cmbPhysique":
                            cmbPhysique.SelectedIndex = -1;
                            SavedStats.Physique = null;
                            break;
                        case "cmbCovenant":
                            cmbCovenant.SelectedIndex = -1;
                            SavedStats.Covenant = null;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
