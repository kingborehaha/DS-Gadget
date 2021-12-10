namespace DS_Gadget
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timerUpdateProcess = new System.Windows.Forms.Timer(this.components);
            this.lblProcessStatic = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.lblLoaded = new System.Windows.Forms.Label();
            this.lblLoadedStatic = new System.Windows.Forms.Label();
            this.lblVersionStatic = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPagePlayer = new System.Windows.Forms.TabPage();
            this.tabPageStats = new System.Windows.Forms.TabPage();
            this.tabPageItems = new System.Windows.Forms.TabPage();
            this.tabPageGraphics = new System.Windows.Forms.TabPage();
            this.tabPageCheats = new System.Windows.Forms.TabPage();
            this.tabPageInternals = new System.Windows.Forms.TabPage();
            this.tabPageMisc = new System.Windows.Forms.TabPage();
            this.tabPageHotkeys = new System.Windows.Forms.TabPage();
            this.lblHotkeyItem = new System.Windows.Forms.Label();
            this.txtHotkeyItem = new System.Windows.Forms.TextBox();
            this.lblHotkeyAI = new System.Windows.Forms.Label();
            this.txtHotkeyAI = new System.Windows.Forms.TextBox();
            this.labelHotkeyDeath = new System.Windows.Forms.Label();
            this.textBoxHotkeyDeath = new System.Windows.Forms.TextBox();
            this.labelHotkeyDown = new System.Windows.Forms.Label();
            this.textBoxHotkeyDown = new System.Windows.Forms.TextBox();
            this.labelHotkeyUp = new System.Windows.Forms.Label();
            this.textBoxHotkeyUp = new System.Windows.Forms.TextBox();
            this.labelHotkeyMenu = new System.Windows.Forms.Label();
            this.textBoxHotkeyMenu = new System.Windows.Forms.TextBox();
            this.labelHotkeyTest1 = new System.Windows.Forms.Label();
            this.textBoxHotkeyTest1 = new System.Windows.Forms.TextBox();
            this.labelHotkeyTest2 = new System.Windows.Forms.Label();
            this.textBoxHotkeyTest2 = new System.Windows.Forms.TextBox();
            this.labelHotkeyInstruction = new System.Windows.Forms.Label();
            this.checkBoxHandleHotkeys = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableHotkeys = new System.Windows.Forms.CheckBox();
            this.labelHotkeySpeed = new System.Windows.Forms.Label();
            this.textBoxHotkeySpeed = new System.Windows.Forms.TextBox();
            this.labelHotkeyCollision = new System.Windows.Forms.Label();
            this.textBoxHotkeyCollision = new System.Windows.Forms.TextBox();
            this.labelHotkeyGravity = new System.Windows.Forms.Label();
            this.textBoxHotkeyGravity = new System.Windows.Forms.TextBox();
            this.labelHotkeyAnim = new System.Windows.Forms.Label();
            this.textBoxHotkeyAnim = new System.Windows.Forms.TextBox();
            this.labelHotkeyMoveswap = new System.Windows.Forms.Label();
            this.textBoxHotkeyMoveswap = new System.Windows.Forms.TextBox();
            this.labelHotkeyFilter = new System.Windows.Forms.Label();
            this.textBoxHotkeyFilter = new System.Windows.Forms.TextBox();
            this.labelHotkeyRestore = new System.Windows.Forms.Label();
            this.textBoxHotkeyRestore = new System.Windows.Forms.TextBox();
            this.textBoxHotkeyStore = new System.Windows.Forms.TextBox();
            this.labelHotkeyStore = new System.Windows.Forms.Label();
            this.labelCheckVersion = new System.Windows.Forms.Label();
            this.llbNewVersion = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gadgetTabPlayer = new DS_Gadget.GadgetTabPlayer();
            this.gadgetTabStats = new DS_Gadget.GadgetTabStats();
            this.gadgetTabItems = new DS_Gadget.GadgetTabItems();
            this.gadgetTabGraphics = new DS_Gadget.GadgetTabGraphics();
            this.gadgetTabCheats = new DS_Gadget.GadgetTabCheats();
            this.gadgetTabInternals = new DS_Gadget.GadgetTabInternals();
            this.gadgetTabMisc = new DS_Gadget.GadgetTabMisc();
            this.tabControlMain.SuspendLayout();
            this.tabPagePlayer.SuspendLayout();
            this.tabPageStats.SuspendLayout();
            this.tabPageItems.SuspendLayout();
            this.tabPageGraphics.SuspendLayout();
            this.tabPageCheats.SuspendLayout();
            this.tabPageInternals.SuspendLayout();
            this.tabPageMisc.SuspendLayout();
            this.tabPageHotkeys.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerUpdateProcess
            // 
            this.timerUpdateProcess.Enabled = true;
            this.timerUpdateProcess.Interval = 16;
            this.timerUpdateProcess.Tick += new System.EventHandler(this.timerUpdateProcess_Tick);
            // 
            // lblProcessStatic
            // 
            this.lblProcessStatic.AutoSize = true;
            this.lblProcessStatic.Location = new System.Drawing.Point(13, 9);
            this.lblProcessStatic.Name = "lblProcessStatic";
            this.lblProcessStatic.Size = new System.Drawing.Size(48, 13);
            this.lblProcessStatic.TabIndex = 0;
            this.lblProcessStatic.Text = "Process:";
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Location = new System.Drawing.Point(70, 9);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(33, 13);
            this.lblProcess.TabIndex = 2;
            this.lblProcess.Text = "None";
            // 
            // lblLoaded
            // 
            this.lblLoaded.AutoSize = true;
            this.lblLoaded.Location = new System.Drawing.Point(70, 34);
            this.lblLoaded.Name = "lblLoaded";
            this.lblLoaded.Size = new System.Drawing.Size(21, 13);
            this.lblLoaded.TabIndex = 3;
            this.lblLoaded.Text = "No";
            // 
            // lblLoadedStatic
            // 
            this.lblLoadedStatic.AutoSize = true;
            this.lblLoadedStatic.Location = new System.Drawing.Point(13, 34);
            this.lblLoadedStatic.Name = "lblLoadedStatic";
            this.lblLoadedStatic.Size = new System.Drawing.Size(46, 13);
            this.lblLoadedStatic.TabIndex = 5;
            this.lblLoadedStatic.Text = "Loaded:";
            // 
            // lblVersionStatic
            // 
            this.lblVersionStatic.AutoSize = true;
            this.lblVersionStatic.Location = new System.Drawing.Point(13, 22);
            this.lblVersionStatic.Name = "lblVersionStatic";
            this.lblVersionStatic.Size = new System.Drawing.Size(45, 13);
            this.lblVersionStatic.TabIndex = 5;
            this.lblVersionStatic.Text = "Version:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(70, 22);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(33, 13);
            this.lblVersion.TabIndex = 4;
            this.lblVersion.Text = "None";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPagePlayer);
            this.tabControlMain.Controls.Add(this.tabPageStats);
            this.tabControlMain.Controls.Add(this.tabPageItems);
            this.tabControlMain.Controls.Add(this.tabPageGraphics);
            this.tabControlMain.Controls.Add(this.tabPageCheats);
            this.tabControlMain.Controls.Add(this.tabPageInternals);
            this.tabControlMain.Controls.Add(this.tabPageMisc);
            this.tabControlMain.Controls.Add(this.tabPageHotkeys);
            this.tabControlMain.Location = new System.Drawing.Point(10, 52);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(397, 533);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPagePlayer
            // 
            this.tabPagePlayer.Controls.Add(this.gadgetTabPlayer);
            this.tabPagePlayer.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPagePlayer.Name = "tabPagePlayer";
            this.tabPagePlayer.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.tabPagePlayer.Size = new System.Drawing.Size(389, 507);
            this.tabPagePlayer.TabIndex = 2;
            this.tabPagePlayer.Text = "Player";
            this.tabPagePlayer.UseVisualStyleBackColor = true;
            // 
            // tabPageStats
            // 
            this.tabPageStats.Controls.Add(this.gadgetTabStats);
            this.tabPageStats.Location = new System.Drawing.Point(4, 22);
            this.tabPageStats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageStats.Name = "tabPageStats";
            this.tabPageStats.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.tabPageStats.Size = new System.Drawing.Size(389, 507);
            this.tabPageStats.TabIndex = 3;
            this.tabPageStats.Text = "Stats";
            this.tabPageStats.UseVisualStyleBackColor = true;
            // 
            // tabPageItems
            // 
            this.tabPageItems.Controls.Add(this.gadgetTabItems);
            this.tabPageItems.Location = new System.Drawing.Point(4, 22);
            this.tabPageItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageItems.Name = "tabPageItems";
            this.tabPageItems.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.tabPageItems.Size = new System.Drawing.Size(389, 507);
            this.tabPageItems.TabIndex = 5;
            this.tabPageItems.Text = "Items";
            this.tabPageItems.UseVisualStyleBackColor = true;
            // 
            // tabPageGraphics
            // 
            this.tabPageGraphics.Controls.Add(this.gadgetTabGraphics);
            this.tabPageGraphics.Location = new System.Drawing.Point(4, 22);
            this.tabPageGraphics.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageGraphics.Name = "tabPageGraphics";
            this.tabPageGraphics.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.tabPageGraphics.Size = new System.Drawing.Size(389, 507);
            this.tabPageGraphics.TabIndex = 0;
            this.tabPageGraphics.Text = "Graphics";
            this.tabPageGraphics.UseVisualStyleBackColor = true;
            // 
            // tabPageCheats
            // 
            this.tabPageCheats.Controls.Add(this.gadgetTabCheats);
            this.tabPageCheats.Location = new System.Drawing.Point(4, 22);
            this.tabPageCheats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageCheats.Name = "tabPageCheats";
            this.tabPageCheats.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.tabPageCheats.Size = new System.Drawing.Size(389, 507);
            this.tabPageCheats.TabIndex = 6;
            this.tabPageCheats.Text = "Cheats";
            this.tabPageCheats.UseVisualStyleBackColor = true;
            // 
            // tabPageInternals
            // 
            this.tabPageInternals.Controls.Add(this.gadgetTabInternals);
            this.tabPageInternals.Location = new System.Drawing.Point(4, 22);
            this.tabPageInternals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageInternals.Name = "tabPageInternals";
            this.tabPageInternals.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.tabPageInternals.Size = new System.Drawing.Size(389, 507);
            this.tabPageInternals.TabIndex = 9;
            this.tabPageInternals.Text = "Internals";
            this.tabPageInternals.UseVisualStyleBackColor = true;
            // 
            // tabPageMisc
            // 
            this.tabPageMisc.Controls.Add(this.gadgetTabMisc);
            this.tabPageMisc.Location = new System.Drawing.Point(4, 22);
            this.tabPageMisc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageMisc.Name = "tabPageMisc";
            this.tabPageMisc.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.tabPageMisc.Size = new System.Drawing.Size(389, 507);
            this.tabPageMisc.TabIndex = 8;
            this.tabPageMisc.Text = "Misc";
            this.tabPageMisc.UseVisualStyleBackColor = true;
            // 
            // tabPageHotkeys
            // 
            this.tabPageHotkeys.Controls.Add(this.lblHotkeyItem);
            this.tabPageHotkeys.Controls.Add(this.txtHotkeyItem);
            this.tabPageHotkeys.Controls.Add(this.lblHotkeyAI);
            this.tabPageHotkeys.Controls.Add(this.txtHotkeyAI);
            this.tabPageHotkeys.Controls.Add(this.labelHotkeyDeath);
            this.tabPageHotkeys.Controls.Add(this.textBoxHotkeyDeath);
            this.tabPageHotkeys.Controls.Add(this.labelHotkeyDown);
            this.tabPageHotkeys.Controls.Add(this.textBoxHotkeyDown);
            this.tabPageHotkeys.Controls.Add(this.labelHotkeyUp);
            this.tabPageHotkeys.Controls.Add(this.textBoxHotkeyUp);
            this.tabPageHotkeys.Controls.Add(this.labelHotkeyMenu);
            this.tabPageHotkeys.Controls.Add(this.textBoxHotkeyMenu);
            this.tabPageHotkeys.Controls.Add(this.labelHotkeyTest1);
            this.tabPageHotkeys.Controls.Add(this.textBoxHotkeyTest1);
            this.tabPageHotkeys.Controls.Add(this.labelHotkeyTest2);
            this.tabPageHotkeys.Controls.Add(this.textBoxHotkeyTest2);
            this.tabPageHotkeys.Controls.Add(this.labelHotkeyInstruction);
            this.tabPageHotkeys.Controls.Add(this.checkBoxHandleHotkeys);
            this.tabPageHotkeys.Controls.Add(this.checkBoxEnableHotkeys);
            this.tabPageHotkeys.Controls.Add(this.labelHotkeySpeed);
            this.tabPageHotkeys.Controls.Add(this.textBoxHotkeySpeed);
            this.tabPageHotkeys.Controls.Add(this.labelHotkeyCollision);
            this.tabPageHotkeys.Controls.Add(this.textBoxHotkeyCollision);
            this.tabPageHotkeys.Controls.Add(this.labelHotkeyGravity);
            this.tabPageHotkeys.Controls.Add(this.textBoxHotkeyGravity);
            this.tabPageHotkeys.Controls.Add(this.labelHotkeyAnim);
            this.tabPageHotkeys.Controls.Add(this.textBoxHotkeyAnim);
            this.tabPageHotkeys.Controls.Add(this.labelHotkeyMoveswap);
            this.tabPageHotkeys.Controls.Add(this.textBoxHotkeyMoveswap);
            this.tabPageHotkeys.Controls.Add(this.labelHotkeyFilter);
            this.tabPageHotkeys.Controls.Add(this.textBoxHotkeyFilter);
            this.tabPageHotkeys.Controls.Add(this.labelHotkeyRestore);
            this.tabPageHotkeys.Controls.Add(this.textBoxHotkeyRestore);
            this.tabPageHotkeys.Controls.Add(this.textBoxHotkeyStore);
            this.tabPageHotkeys.Controls.Add(this.labelHotkeyStore);
            this.tabPageHotkeys.Location = new System.Drawing.Point(4, 22);
            this.tabPageHotkeys.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageHotkeys.Name = "tabPageHotkeys";
            this.tabPageHotkeys.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.tabPageHotkeys.Size = new System.Drawing.Size(389, 507);
            this.tabPageHotkeys.TabIndex = 7;
            this.tabPageHotkeys.Text = "Hotkeys";
            this.tabPageHotkeys.UseVisualStyleBackColor = true;
            // 
            // lblHotkeyItem
            // 
            this.lblHotkeyItem.AutoSize = true;
            this.lblHotkeyItem.Location = new System.Drawing.Point(116, 374);
            this.lblHotkeyItem.Name = "lblHotkeyItem";
            this.lblHotkeyItem.Size = new System.Drawing.Size(106, 13);
            this.lblHotkeyItem.TabIndex = 32;
            this.lblHotkeyItem.Text = "Create Selected Item";
            this.toolTip1.SetToolTip(this.lblHotkeyItem, "Escape sitting bonfire animation without leaving bonfire");
            // 
            // txtHotkeyItem
            // 
            this.txtHotkeyItem.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtHotkeyItem.Location = new System.Drawing.Point(6, 371);
            this.txtHotkeyItem.Name = "txtHotkeyItem";
            this.txtHotkeyItem.Size = new System.Drawing.Size(106, 20);
            this.txtHotkeyItem.TabIndex = 31;
            this.txtHotkeyItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHotkeyAI
            // 
            this.lblHotkeyAI.AutoSize = true;
            this.lblHotkeyAI.Location = new System.Drawing.Point(116, 399);
            this.lblHotkeyAI.Name = "lblHotkeyAI";
            this.lblHotkeyAI.Size = new System.Drawing.Size(53, 13);
            this.lblHotkeyAI.TabIndex = 32;
            this.lblHotkeyAI.Text = "Toggle AI";
            this.toolTip1.SetToolTip(this.lblHotkeyAI, "Escape sitting bonfire animation without leaving bonfire");
            // 
            // txtHotkeyAI
            // 
            this.txtHotkeyAI.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtHotkeyAI.Location = new System.Drawing.Point(6, 397);
            this.txtHotkeyAI.Name = "txtHotkeyAI";
            this.txtHotkeyAI.Size = new System.Drawing.Size(106, 20);
            this.txtHotkeyAI.TabIndex = 31;
            this.txtHotkeyAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHotkeyDeath
            // 
            this.labelHotkeyDeath.AutoSize = true;
            this.labelHotkeyDeath.Location = new System.Drawing.Point(116, 271);
            this.labelHotkeyDeath.Name = "labelHotkeyDeath";
            this.labelHotkeyDeath.Size = new System.Drawing.Size(89, 13);
            this.labelHotkeyDeath.TabIndex = 30;
            this.labelHotkeyDeath.Text = "Toggle No Death";
            // 
            // textBoxHotkeyDeath
            // 
            this.textBoxHotkeyDeath.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxHotkeyDeath.Location = new System.Drawing.Point(6, 269);
            this.textBoxHotkeyDeath.Name = "textBoxHotkeyDeath";
            this.textBoxHotkeyDeath.Size = new System.Drawing.Size(106, 20);
            this.textBoxHotkeyDeath.TabIndex = 29;
            this.textBoxHotkeyDeath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHotkeyDown
            // 
            this.labelHotkeyDown.AutoSize = true;
            this.labelHotkeyDown.Location = new System.Drawing.Point(116, 169);
            this.labelHotkeyDown.Name = "labelHotkeyDown";
            this.labelHotkeyDown.Size = new System.Drawing.Size(65, 13);
            this.labelHotkeyDown.TabIndex = 28;
            this.labelHotkeyDown.Text = "Move Down";
            this.toolTip1.SetToolTip(this.labelHotkeyDown, "Teleport downwards 5 Miyazaki Units");
            // 
            // textBoxHotkeyDown
            // 
            this.textBoxHotkeyDown.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxHotkeyDown.Location = new System.Drawing.Point(6, 166);
            this.textBoxHotkeyDown.Name = "textBoxHotkeyDown";
            this.textBoxHotkeyDown.Size = new System.Drawing.Size(106, 20);
            this.textBoxHotkeyDown.TabIndex = 27;
            this.textBoxHotkeyDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHotkeyUp
            // 
            this.labelHotkeyUp.AutoSize = true;
            this.labelHotkeyUp.Location = new System.Drawing.Point(116, 143);
            this.labelHotkeyUp.Name = "labelHotkeyUp";
            this.labelHotkeyUp.Size = new System.Drawing.Size(51, 13);
            this.labelHotkeyUp.TabIndex = 26;
            this.labelHotkeyUp.Text = "Move Up";
            this.toolTip1.SetToolTip(this.labelHotkeyUp, "Teleport upwards 5 Miyazaki Units");
            // 
            // textBoxHotkeyUp
            // 
            this.textBoxHotkeyUp.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxHotkeyUp.Location = new System.Drawing.Point(6, 141);
            this.textBoxHotkeyUp.Name = "textBoxHotkeyUp";
            this.textBoxHotkeyUp.Size = new System.Drawing.Size(106, 20);
            this.textBoxHotkeyUp.TabIndex = 25;
            this.textBoxHotkeyUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHotkeyMenu
            // 
            this.labelHotkeyMenu.AutoSize = true;
            this.labelHotkeyMenu.Location = new System.Drawing.Point(116, 66);
            this.labelHotkeyMenu.Name = "labelHotkeyMenu";
            this.labelHotkeyMenu.Size = new System.Drawing.Size(68, 13);
            this.labelHotkeyMenu.TabIndex = 24;
            this.labelHotkeyMenu.Text = "Quit to Menu";
            this.toolTip1.SetToolTip(this.labelHotkeyMenu, "Immediately quit to menu, even while dead");
            // 
            // textBoxHotkeyMenu
            // 
            this.textBoxHotkeyMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxHotkeyMenu.Location = new System.Drawing.Point(6, 64);
            this.textBoxHotkeyMenu.Name = "textBoxHotkeyMenu";
            this.textBoxHotkeyMenu.Size = new System.Drawing.Size(106, 20);
            this.textBoxHotkeyMenu.TabIndex = 23;
            this.textBoxHotkeyMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHotkeyTest1
            // 
            this.labelHotkeyTest1.AutoSize = true;
            this.labelHotkeyTest1.Location = new System.Drawing.Point(116, 458);
            this.labelHotkeyTest1.Name = "labelHotkeyTest1";
            this.labelHotkeyTest1.Size = new System.Drawing.Size(37, 13);
            this.labelHotkeyTest1.TabIndex = 22;
            this.labelHotkeyTest1.Text = "Test 1";
            // 
            // textBoxHotkeyTest1
            // 
            this.textBoxHotkeyTest1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxHotkeyTest1.Location = new System.Drawing.Point(6, 456);
            this.textBoxHotkeyTest1.Name = "textBoxHotkeyTest1";
            this.textBoxHotkeyTest1.Size = new System.Drawing.Size(106, 20);
            this.textBoxHotkeyTest1.TabIndex = 21;
            this.textBoxHotkeyTest1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHotkeyTest2
            // 
            this.labelHotkeyTest2.AutoSize = true;
            this.labelHotkeyTest2.Location = new System.Drawing.Point(116, 484);
            this.labelHotkeyTest2.Name = "labelHotkeyTest2";
            this.labelHotkeyTest2.Size = new System.Drawing.Size(37, 13);
            this.labelHotkeyTest2.TabIndex = 20;
            this.labelHotkeyTest2.Text = "Test 2";
            // 
            // textBoxHotkeyTest2
            // 
            this.textBoxHotkeyTest2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxHotkeyTest2.Location = new System.Drawing.Point(6, 482);
            this.textBoxHotkeyTest2.Name = "textBoxHotkeyTest2";
            this.textBoxHotkeyTest2.Size = new System.Drawing.Size(106, 20);
            this.textBoxHotkeyTest2.TabIndex = 19;
            this.textBoxHotkeyTest2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHotkeyInstruction
            // 
            this.labelHotkeyInstruction.AutoSize = true;
            this.labelHotkeyInstruction.Location = new System.Drawing.Point(3, 47);
            this.labelHotkeyInstruction.Name = "labelHotkeyInstruction";
            this.labelHotkeyInstruction.Size = new System.Drawing.Size(213, 13);
            this.labelHotkeyInstruction.TabIndex = 18;
            this.labelHotkeyInstruction.Text = "Click box to rebind; press escape to unbind.";
            // 
            // checkBoxHandleHotkeys
            // 
            this.checkBoxHandleHotkeys.AutoSize = true;
            this.checkBoxHandleHotkeys.Checked = true;
            this.checkBoxHandleHotkeys.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHandleHotkeys.Location = new System.Drawing.Point(3, 28);
            this.checkBoxHandleHotkeys.Name = "checkBoxHandleHotkeys";
            this.checkBoxHandleHotkeys.Size = new System.Drawing.Size(115, 17);
            this.checkBoxHandleHotkeys.TabIndex = 17;
            this.checkBoxHandleHotkeys.Text = "Consume keypress";
            this.toolTip1.SetToolTip(this.checkBoxHandleHotkeys, "Keypresses caught will not be passed on to the game");
            this.checkBoxHandleHotkeys.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableHotkeys
            // 
            this.checkBoxEnableHotkeys.AutoSize = true;
            this.checkBoxEnableHotkeys.Checked = true;
            this.checkBoxEnableHotkeys.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnableHotkeys.Location = new System.Drawing.Point(3, 5);
            this.checkBoxEnableHotkeys.Name = "checkBoxEnableHotkeys";
            this.checkBoxEnableHotkeys.Size = new System.Drawing.Size(99, 17);
            this.checkBoxEnableHotkeys.TabIndex = 16;
            this.checkBoxEnableHotkeys.Text = "Enable hotkeys";
            this.checkBoxEnableHotkeys.UseVisualStyleBackColor = true;
            // 
            // labelHotkeySpeed
            // 
            this.labelHotkeySpeed.AutoSize = true;
            this.labelHotkeySpeed.Location = new System.Drawing.Point(116, 246);
            this.labelHotkeySpeed.Name = "labelHotkeySpeed";
            this.labelHotkeySpeed.Size = new System.Drawing.Size(74, 13);
            this.labelHotkeySpeed.TabIndex = 15;
            this.labelHotkeySpeed.Text = "Toggle Speed";
            this.toolTip1.SetToolTip(this.labelHotkeySpeed, "Toggle speed modification in Player");
            // 
            // textBoxHotkeySpeed
            // 
            this.textBoxHotkeySpeed.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxHotkeySpeed.Location = new System.Drawing.Point(6, 243);
            this.textBoxHotkeySpeed.Name = "textBoxHotkeySpeed";
            this.textBoxHotkeySpeed.Size = new System.Drawing.Size(106, 20);
            this.textBoxHotkeySpeed.TabIndex = 14;
            this.textBoxHotkeySpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHotkeyCollision
            // 
            this.labelHotkeyCollision.AutoSize = true;
            this.labelHotkeyCollision.Location = new System.Drawing.Point(116, 220);
            this.labelHotkeyCollision.Name = "labelHotkeyCollision";
            this.labelHotkeyCollision.Size = new System.Drawing.Size(81, 13);
            this.labelHotkeyCollision.TabIndex = 13;
            this.labelHotkeyCollision.Text = "Toggle Collision";
            // 
            // textBoxHotkeyCollision
            // 
            this.textBoxHotkeyCollision.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxHotkeyCollision.Location = new System.Drawing.Point(6, 218);
            this.textBoxHotkeyCollision.Name = "textBoxHotkeyCollision";
            this.textBoxHotkeyCollision.Size = new System.Drawing.Size(106, 20);
            this.textBoxHotkeyCollision.TabIndex = 12;
            this.textBoxHotkeyCollision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHotkeyGravity
            // 
            this.labelHotkeyGravity.AutoSize = true;
            this.labelHotkeyGravity.Location = new System.Drawing.Point(116, 194);
            this.labelHotkeyGravity.Name = "labelHotkeyGravity";
            this.labelHotkeyGravity.Size = new System.Drawing.Size(76, 13);
            this.labelHotkeyGravity.TabIndex = 11;
            this.labelHotkeyGravity.Text = "Toggle Gravity";
            // 
            // textBoxHotkeyGravity
            // 
            this.textBoxHotkeyGravity.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxHotkeyGravity.Location = new System.Drawing.Point(6, 192);
            this.textBoxHotkeyGravity.Name = "textBoxHotkeyGravity";
            this.textBoxHotkeyGravity.Size = new System.Drawing.Size(106, 20);
            this.textBoxHotkeyGravity.TabIndex = 10;
            this.textBoxHotkeyGravity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHotkeyAnim
            // 
            this.labelHotkeyAnim.AutoSize = true;
            this.labelHotkeyAnim.Location = new System.Drawing.Point(116, 348);
            this.labelHotkeyAnim.Name = "labelHotkeyAnim";
            this.labelHotkeyAnim.Size = new System.Drawing.Size(89, 13);
            this.labelHotkeyAnim.TabIndex = 9;
            this.labelHotkeyAnim.Text = "Cancel Animation";
            this.toolTip1.SetToolTip(this.labelHotkeyAnim, "Cancel current animation (from stun, gesture, etc)");
            // 
            // textBoxHotkeyAnim
            // 
            this.textBoxHotkeyAnim.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxHotkeyAnim.Location = new System.Drawing.Point(6, 346);
            this.textBoxHotkeyAnim.Name = "textBoxHotkeyAnim";
            this.textBoxHotkeyAnim.Size = new System.Drawing.Size(106, 20);
            this.textBoxHotkeyAnim.TabIndex = 8;
            this.textBoxHotkeyAnim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHotkeyMoveswap
            // 
            this.labelHotkeyMoveswap.AutoSize = true;
            this.labelHotkeyMoveswap.Location = new System.Drawing.Point(116, 322);
            this.labelHotkeyMoveswap.Name = "labelHotkeyMoveswap";
            this.labelHotkeyMoveswap.Size = new System.Drawing.Size(59, 13);
            this.labelHotkeyMoveswap.TabIndex = 7;
            this.labelHotkeyMoveswap.Text = "Moveswap";
            this.toolTip1.SetToolTip(this.labelHotkeyMoveswap, "Two-hand your offhand weapon");
            // 
            // textBoxHotkeyMoveswap
            // 
            this.textBoxHotkeyMoveswap.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxHotkeyMoveswap.Location = new System.Drawing.Point(6, 320);
            this.textBoxHotkeyMoveswap.Name = "textBoxHotkeyMoveswap";
            this.textBoxHotkeyMoveswap.Size = new System.Drawing.Size(106, 20);
            this.textBoxHotkeyMoveswap.TabIndex = 6;
            this.textBoxHotkeyMoveswap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHotkeyFilter
            // 
            this.labelHotkeyFilter.AutoSize = true;
            this.labelHotkeyFilter.Location = new System.Drawing.Point(116, 297);
            this.labelHotkeyFilter.Name = "labelHotkeyFilter";
            this.labelHotkeyFilter.Size = new System.Drawing.Size(65, 13);
            this.labelHotkeyFilter.TabIndex = 5;
            this.labelHotkeyFilter.Text = "Toggle Filter";
            // 
            // textBoxHotkeyFilter
            // 
            this.textBoxHotkeyFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxHotkeyFilter.Location = new System.Drawing.Point(6, 294);
            this.textBoxHotkeyFilter.Name = "textBoxHotkeyFilter";
            this.textBoxHotkeyFilter.Size = new System.Drawing.Size(106, 20);
            this.textBoxHotkeyFilter.TabIndex = 4;
            this.textBoxHotkeyFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHotkeyRestore
            // 
            this.labelHotkeyRestore.AutoSize = true;
            this.labelHotkeyRestore.Location = new System.Drawing.Point(116, 118);
            this.labelHotkeyRestore.Name = "labelHotkeyRestore";
            this.labelHotkeyRestore.Size = new System.Drawing.Size(84, 13);
            this.labelHotkeyRestore.TabIndex = 3;
            this.labelHotkeyRestore.Text = "Restore Position";
            this.toolTip1.SetToolTip(this.labelHotkeyRestore, "Restore position (and state, if enabled in Player)");
            // 
            // textBoxHotkeyRestore
            // 
            this.textBoxHotkeyRestore.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxHotkeyRestore.Location = new System.Drawing.Point(6, 115);
            this.textBoxHotkeyRestore.Name = "textBoxHotkeyRestore";
            this.textBoxHotkeyRestore.Size = new System.Drawing.Size(106, 20);
            this.textBoxHotkeyRestore.TabIndex = 2;
            this.textBoxHotkeyRestore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHotkeyStore
            // 
            this.textBoxHotkeyStore.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxHotkeyStore.Location = new System.Drawing.Point(6, 90);
            this.textBoxHotkeyStore.Name = "textBoxHotkeyStore";
            this.textBoxHotkeyStore.Size = new System.Drawing.Size(106, 20);
            this.textBoxHotkeyStore.TabIndex = 1;
            this.textBoxHotkeyStore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHotkeyStore
            // 
            this.labelHotkeyStore.AutoSize = true;
            this.labelHotkeyStore.Location = new System.Drawing.Point(116, 92);
            this.labelHotkeyStore.Name = "labelHotkeyStore";
            this.labelHotkeyStore.Size = new System.Drawing.Size(72, 13);
            this.labelHotkeyStore.TabIndex = 0;
            this.labelHotkeyStore.Text = "Store Position";
            this.toolTip1.SetToolTip(this.labelHotkeyStore, "Store position and state");
            // 
            // labelCheckVersion
            // 
            this.labelCheckVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCheckVersion.Location = new System.Drawing.Point(46, 9);
            this.labelCheckVersion.Name = "labelCheckVersion";
            this.labelCheckVersion.Size = new System.Drawing.Size(361, 22);
            this.labelCheckVersion.TabIndex = 6;
            this.labelCheckVersion.Text = "Checking for new version...";
            this.labelCheckVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // llbNewVersion
            // 
            this.llbNewVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llbNewVersion.Location = new System.Drawing.Point(157, 9);
            this.llbNewVersion.Name = "llbNewVersion";
            this.llbNewVersion.Size = new System.Drawing.Size(249, 22);
            this.llbNewVersion.TabIndex = 7;
            this.llbNewVersion.TabStop = true;
            this.llbNewVersion.Text = "New version available!";
            this.llbNewVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.llbNewVersion.Visible = false;
            this.llbNewVersion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelNewVersion_LinkClicked);
            // 
            // gadgetTabPlayer
            // 
            this.gadgetTabPlayer.AutoSize = true;
            this.gadgetTabPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gadgetTabPlayer.Location = new System.Drawing.Point(0, 2);
            this.gadgetTabPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.gadgetTabPlayer.Name = "gadgetTabPlayer";
            this.gadgetTabPlayer.Size = new System.Drawing.Size(389, 505);
            this.gadgetTabPlayer.TabIndex = 0;
            // 
            // gadgetTabStats
            // 
            this.gadgetTabStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gadgetTabStats.Location = new System.Drawing.Point(0, 2);
            this.gadgetTabStats.Margin = new System.Windows.Forms.Padding(2);
            this.gadgetTabStats.Name = "gadgetTabStats";
            this.gadgetTabStats.Size = new System.Drawing.Size(389, 505);
            this.gadgetTabStats.TabIndex = 0;
            // 
            // gadgetTabItems
            // 
            this.gadgetTabItems.AutoSize = true;
            this.gadgetTabItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gadgetTabItems.Location = new System.Drawing.Point(0, 2);
            this.gadgetTabItems.Margin = new System.Windows.Forms.Padding(2);
            this.gadgetTabItems.Name = "gadgetTabItems";
            this.gadgetTabItems.Size = new System.Drawing.Size(389, 505);
            this.gadgetTabItems.TabIndex = 0;
            // 
            // gadgetTabGraphics
            // 
            this.gadgetTabGraphics.AutoSize = true;
            this.gadgetTabGraphics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gadgetTabGraphics.Location = new System.Drawing.Point(0, 2);
            this.gadgetTabGraphics.Margin = new System.Windows.Forms.Padding(2);
            this.gadgetTabGraphics.Name = "gadgetTabGraphics";
            this.gadgetTabGraphics.Size = new System.Drawing.Size(389, 505);
            this.gadgetTabGraphics.TabIndex = 0;
            // 
            // gadgetTabCheats
            // 
            this.gadgetTabCheats.AutoSize = true;
            this.gadgetTabCheats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gadgetTabCheats.Location = new System.Drawing.Point(0, 2);
            this.gadgetTabCheats.Margin = new System.Windows.Forms.Padding(2);
            this.gadgetTabCheats.Name = "gadgetTabCheats";
            this.gadgetTabCheats.Size = new System.Drawing.Size(389, 505);
            this.gadgetTabCheats.TabIndex = 0;
            // 
            // gadgetTabInternals
            // 
            this.gadgetTabInternals.AutoSize = true;
            this.gadgetTabInternals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gadgetTabInternals.Location = new System.Drawing.Point(0, 2);
            this.gadgetTabInternals.Margin = new System.Windows.Forms.Padding(2);
            this.gadgetTabInternals.Name = "gadgetTabInternals";
            this.gadgetTabInternals.Size = new System.Drawing.Size(389, 505);
            this.gadgetTabInternals.TabIndex = 0;
            // 
            // gadgetTabMisc
            // 
            this.gadgetTabMisc.AutoSize = true;
            this.gadgetTabMisc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gadgetTabMisc.Location = new System.Drawing.Point(0, 2);
            this.gadgetTabMisc.Margin = new System.Windows.Forms.Padding(2);
            this.gadgetTabMisc.Name = "gadgetTabMisc";
            this.gadgetTabMisc.Size = new System.Drawing.Size(389, 505);
            this.gadgetTabMisc.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(416, 594);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblVersionStatic);
            this.Controls.Add(this.lblLoadedStatic);
            this.Controls.Add(this.lblLoaded);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.lblProcessStatic);
            this.Controls.Add(this.llbNewVersion);
            this.Controls.Add(this.labelCheckVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DS Gadget <version>";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPagePlayer.ResumeLayout(false);
            this.tabPagePlayer.PerformLayout();
            this.tabPageStats.ResumeLayout(false);
            this.tabPageItems.ResumeLayout(false);
            this.tabPageItems.PerformLayout();
            this.tabPageGraphics.ResumeLayout(false);
            this.tabPageGraphics.PerformLayout();
            this.tabPageCheats.ResumeLayout(false);
            this.tabPageCheats.PerformLayout();
            this.tabPageInternals.ResumeLayout(false);
            this.tabPageInternals.PerformLayout();
            this.tabPageMisc.ResumeLayout(false);
            this.tabPageMisc.PerformLayout();
            this.tabPageHotkeys.ResumeLayout(false);
            this.tabPageHotkeys.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerUpdateProcess;
        private System.Windows.Forms.Label lblProcessStatic;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label lblLoaded;
        private System.Windows.Forms.Label lblLoadedStatic;
        private System.Windows.Forms.Label lblVersionStatic;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageGraphics;
        private System.Windows.Forms.TabPage tabPagePlayer;
        private System.Windows.Forms.TabPage tabPageItems;
        private System.Windows.Forms.TabPage tabPageStats;
        private System.Windows.Forms.TabPage tabPageCheats;
        private System.Windows.Forms.TabPage tabPageHotkeys;
        private System.Windows.Forms.Label labelHotkeyMoveswap;
        private System.Windows.Forms.TextBox textBoxHotkeyMoveswap;
        private System.Windows.Forms.Label labelHotkeyFilter;
        private System.Windows.Forms.TextBox textBoxHotkeyFilter;
        private System.Windows.Forms.Label labelHotkeyRestore;
        private System.Windows.Forms.TextBox textBoxHotkeyRestore;
        private System.Windows.Forms.TextBox textBoxHotkeyStore;
        private System.Windows.Forms.Label labelHotkeyStore;
        private System.Windows.Forms.Label labelHotkeyAnim;
        private System.Windows.Forms.TextBox textBoxHotkeyAnim;
        private System.Windows.Forms.Label labelHotkeySpeed;
        private System.Windows.Forms.TextBox textBoxHotkeySpeed;
        private System.Windows.Forms.Label labelHotkeyCollision;
        private System.Windows.Forms.TextBox textBoxHotkeyCollision;
        private System.Windows.Forms.Label labelHotkeyGravity;
        private System.Windows.Forms.TextBox textBoxHotkeyGravity;
        private System.Windows.Forms.Label labelCheckVersion;
        private System.Windows.Forms.LinkLabel llbNewVersion;
        private System.Windows.Forms.Label labelHotkeyInstruction;
        private System.Windows.Forms.CheckBox checkBoxHandleHotkeys;
        private System.Windows.Forms.CheckBox checkBoxEnableHotkeys;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabPageMisc;
        private System.Windows.Forms.Label labelHotkeyTest1;
        private System.Windows.Forms.TextBox textBoxHotkeyTest1;
        private System.Windows.Forms.Label labelHotkeyTest2;
        private System.Windows.Forms.TextBox textBoxHotkeyTest2;
        private System.Windows.Forms.Label labelHotkeyDeath;
        private System.Windows.Forms.TextBox textBoxHotkeyDeath;
        private System.Windows.Forms.Label labelHotkeyDown;
        private System.Windows.Forms.TextBox textBoxHotkeyDown;
        private System.Windows.Forms.Label labelHotkeyUp;
        private System.Windows.Forms.TextBox textBoxHotkeyUp;
        private System.Windows.Forms.Label labelHotkeyMenu;
        private System.Windows.Forms.TextBox textBoxHotkeyMenu;
        private System.Windows.Forms.TabPage tabPageInternals;
        private System.Windows.Forms.Label lblHotkeyItem;
        private System.Windows.Forms.TextBox txtHotkeyItem;
        private System.Windows.Forms.Label lblHotkeyAI;
        private System.Windows.Forms.TextBox txtHotkeyAI;
        private GadgetTabItems gadgetTabItems;
        private GadgetTabPlayer gadgetTabPlayer;
        private GadgetTabInternals gadgetTabInternals;
        private GadgetTabMisc gadgetTabMisc;
        private GadgetTabStats gadgetTabStats;
        private GadgetTabCheats gadgetTabCheats;
        private GadgetTabGraphics gadgetTabGraphics;
    }
}

