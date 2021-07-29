using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS_Gadget
{
    internal partial class GadgetTabMisc : GadgetTab
    {
        public GadgetTabMisc()
        {
            InitializeComponent();
        }

        private void btnEventFlagRead_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtEventFlagID.Text, out int id))
                cbxEventFlagValue.Checked = Hook.ReadEventFlag(id);
        }

        private void btnEventFlagWrite_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtEventFlagID.Text, out int id))
                Hook.WriteEventFlag(id, cbxEventFlagValue.Checked);
        }

        private void btnUnlockGestures_Click(object sender, EventArgs e)
        {
            Hook.UnlockAllGestures();
        }

        public override void InitTab(MainForm parent)
        {
            base.InitTab(parent);
            DSFashionCategory.GetItemCategories();
            foreach (DSFashionCategory category in DSFashionCategory.All)
                cmbCategory.Items.Add(category);
            cmbCategory.SelectedIndex = 0;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBox.Text = "Search...";
            lbxItems.Items.Clear();
            DSFashionCategory category = cmbCategory.SelectedItem as DSFashionCategory;
            foreach (DSItem item in category.Items)
                lbxItems.Items.Add(item);
            lbxItems.SelectedIndex = 0;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            lbxItems.Items.Clear();
            DSFashionCategory category = cmbCategory.SelectedItem as DSFashionCategory;
            foreach (DSItem item in category.Items)
            {
                if (item.ToString().ToLower().Contains(searchBox.Text.ToLower()))
                {
                    lbxItems.Items.Add(item);
                }

            }

            if (lbxItems.Items.Count > 0)
                lbxItems.SelectedIndex = 0;
        }

        private void lbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            DSItem item = lbxItems.SelectedItem as DSItem;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.DarkGray);
            ApplyHair();
        }

        private void ApplyHair()
        {
            if (btnApplyHair.Enabled == true)
            {
                ChangeColor(Color.DarkGray);
                DSFashionCategory category = cmbCategory.SelectedItem as DSFashionCategory;
                DSItem item = lbxItems.SelectedItem as DSItem;
                int id = item.ID;
                Hook.EquipHairID = id;
            }
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            searchBox.SelectAll();
            searchBox.Focus();
        }

        private void KeyDownListbox(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;

                if (lbxItems.SelectedIndex < lbxItems.Items.Count - 1)
                {
                    lbxItems.SelectedIndex += 1;
                    return;
                }

                if (lbxItems.SelectedIndex >= lbxItems.Items.Count - 1)
                {
                    lbxItems.SelectedIndex = 0;
                    return;
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                e.Handled = true;

                if (lbxItems.SelectedIndex == 0)
                {
                    lbxItems.SelectedIndex = lbxItems.Items.Count - 1;
                    return;
                }

                if (lbxItems.SelectedIndex != 0)
                {
                    lbxItems.SelectedIndex -= 1;
                    return;
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                ApplyHair();
                return;
            }
        }

        internal void EnableStats(bool enable)
        {
            btnApplyHair.Enabled = enable;
            btnEventFlagRead.Enabled = enable;
            btnEventFlagWrite.Enabled = enable;
        }

        private async Task ChangeColor(Color new_color)
        {
            btnApplyHair.BackColor = new_color;

            await Task.Delay(TimeSpan.FromSeconds(.25));

            btnApplyHair.BackColor = default(Color);
        }

        private void KeyPressed(object sender, KeyEventArgs e)
        {
            if (lbxItems.Items.Count > 0)
                KeyDownListbox(e);

            if (lbxItems.Items.Count == 0)
            {
                if (e.KeyCode == Keys.Up)
                    e.Handled = true;
                if (e.KeyCode == Keys.Down)
                    e.Handled = true;
            }
        }

    }
}
