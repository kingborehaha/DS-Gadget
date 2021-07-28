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

            Hook.LevelUp(vitality, attunement, endurance, strength, dexterity, resistance, intelligence, faith, sl);
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

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cmbPhysique_SelectedIndexChanged(object sender, EventArgs e)
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
                    SavedStats.Souls = nudHumanity.Value;
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
                        case "nudFai":
                            SavedStats.Fth = nudFth.Value;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void cmbCovenant_SelectedIndexChanged(object sender, EventArgs e)
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

        private void LoadSavedStats()
        {
            if (Hook.Loaded)
            {
                if (string.IsNullOrWhiteSpace(SavedStats.Name))
                {
                    Hook.CharName = SavedStats.Name;
                    txtName.Text = SavedStats.Name;
                }

                if (SavedStats.Sex.HasValue)
                {
                    cmbSex.SelectedIndex = SavedStats.Sex.Value;
                    cmbSex_SelectedIndexChanged(null, null);
                }

                if (SavedStats.Class.HasValue)
                {
                    cmbClass.SelectedIndex = SavedStats.Class.Value;
                    cmbClass_SelectedIndexChanged(null, null);
                }

                if (SavedStats.Physique.HasValue)
                {
                    cmbPhysique.SelectedIndex = SavedStats.Physique.Value;
                    cmbPhysique_SelectedIndexChanged(null, null);
                }

                if (SavedStats.Humanity.HasValue)
                {
                    nudHumanity.Value = SavedStats.Humanity.Value;
                    nudHumanity_ValueChanged(null, null);
                }

                if (SavedStats.Souls.HasValue)
                {
                    nudSouls.Value = SavedStats.Humanity.Value;
                    nudSouls_ValueChanged(null, null);
                }

                if (SavedStats.Vit.HasValue)
                {
                    nudVit.Value = SavedStats.Vit.Value;
                }

                if (SavedStats.Att.HasValue)
                {
                    nudAtt.Value = SavedStats.Att.Value;
                }

                if (SavedStats.End.HasValue)
                {
                    nudEnd.Value = SavedStats.End.Value;
                }

                if (SavedStats.Str.HasValue)
                {
                    nudStr.Value = SavedStats.Str.Value;
                }

                if (SavedStats.Dex.HasValue)
                {
                    nudDex.Value = SavedStats.Dex.Value;
                }

                if (SavedStats.Res.HasValue)
                {
                    nudRes.Value = SavedStats.Res.Value;
                }

                if (SavedStats.Int.HasValue)
                {
                    nudInt.Value = SavedStats.Int.Value;
                }

                if (SavedStats.Fth.HasValue)
                {
                    nudFth.Value = SavedStats.Fth.Value;
                }

                RecalculateStats();

                if (SavedStats.Covenant.HasValue)
                {
                    cmbCovenant.SelectedIndex = SavedStats.Covenant.Value;
                    cmbCovenant_SelectedIndexChanged(null, null);
                }

                if (SavedStats.CovChaos.HasValue)
                {
                    nudCovChaos.Value = SavedStats.CovChaos.Value;
                    nudCovChaos_ValueChanged(null, null);
                }

                if (SavedStats.CovDarkmoon.HasValue)
                {
                    nudCovDarkmoon.Value = SavedStats.CovDarkmoon.Value;
                    nudCovDarkmoon_ValueChanged(null, null);
                }

                if (SavedStats.CovDarkwraith.HasValue)
                {
                    nudCovDarkwraith.Value = SavedStats.CovDarkwraith.Value;
                    nudCovDarkwraith_ValueChanged(null, null);
                }

                if (SavedStats.CovForest.HasValue)
                {
                    nudCovForest.Value = SavedStats.CovForest.Value;
                    nudCovForest_ValueChanged(null, null);
                }

                if (SavedStats.CovGravelord.HasValue)
                {
                    nudCovGravelord.Value = SavedStats.CovGravelord.Value;
                    nudCovGravelord_ValueChanged(null, null);
                }

                if (SavedStats.CovDragon.HasValue)
                {
                    nudCovDragon.Value = SavedStats.CovDragon.Value;
                    nudCovDragon_ValueChanged(null, null);
                }

                if (SavedStats.CovSunlight.HasValue)
                {
                    nudCovSunlight.Value = SavedStats.CovSunlight.Value;
                    nudCovSunlight_ValueChanged(null, null);
                }
            }

        }
    }
}
