namespace TrinityCore_Manager
{
    partial class FindNPCFlag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindNPCFlag));
            this.checkAllButton = new DevComponents.DotNetBar.ButtonX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.bankerCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.innkeeperCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.spiritGuideCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.spiritHealerCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.flightMasterCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.repairerCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.vendorReagentCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.vendorPoisonCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.vendorFoodCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.vendorAmmoCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.vendorCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.professionTrainerCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.classTrainerCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.trainerCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.questGiverCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.gossipCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.mailboxCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.spellclickCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.guildBankerCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.stableMasterCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.auctioneerCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.battlemasterCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.tabardDesignerCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.petitionerCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.npcFlagSuperTooltip = new DevComponents.DotNetBar.SuperTooltip();
            this.SuspendLayout();
            // 
            // checkAllButton
            // 
            this.checkAllButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.checkAllButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.checkAllButton.Location = new System.Drawing.Point(12, 361);
            this.checkAllButton.Name = "checkAllButton";
            this.checkAllButton.Size = new System.Drawing.Size(106, 35);
            this.checkAllButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkAllButton.TabIndex = 35;
            this.checkAllButton.Text = "Check All";
            this.checkAllButton.TextColor = System.Drawing.Color.Green;
            this.checkAllButton.Click += new System.EventHandler(this.checkAllButton_Click);
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(207, 361);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(106, 35);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 34;
            this.okButton.Text = "Ok";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // bankerCheckBox
            // 
            // 
            // 
            // 
            this.bankerCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.bankerCheckBox.Location = new System.Drawing.Point(186, 99);
            this.bankerCheckBox.Name = "bankerCheckBox";
            this.bankerCheckBox.Size = new System.Drawing.Size(148, 23);
            this.bankerCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.npcFlagSuperTooltip.SetSuperTooltip(this.bankerCheckBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Creatures with this flag can show the bank\r\n", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.bankerCheckBox.TabIndex = 51;
            this.bankerCheckBox.Text = "BANKER";
            // 
            // innkeeperCheckBox
            // 
            // 
            // 
            // 
            this.innkeeperCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.innkeeperCheckBox.Location = new System.Drawing.Point(186, 70);
            this.innkeeperCheckBox.Name = "innkeeperCheckBox";
            this.innkeeperCheckBox.Size = new System.Drawing.Size(148, 23);
            this.innkeeperCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.npcFlagSuperTooltip.SetSuperTooltip(this.innkeeperCheckBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Creatures with this flag can set hearthstone locations.\r\n", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.innkeeperCheckBox.TabIndex = 50;
            this.innkeeperCheckBox.Text = "INNKEEPER";
            // 
            // spiritGuideCheckBox
            // 
            // 
            // 
            // 
            this.spiritGuideCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.spiritGuideCheckBox.Location = new System.Drawing.Point(186, 41);
            this.spiritGuideCheckBox.Name = "spiritGuideCheckBox";
            this.spiritGuideCheckBox.Size = new System.Drawing.Size(148, 23);
            this.spiritGuideCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.spiritGuideCheckBox.TabIndex = 49;
            this.spiritGuideCheckBox.Text = "SPIRIT_GUIDE";
            // 
            // spiritHealerCheckBox
            // 
            // 
            // 
            // 
            this.spiritHealerCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.spiritHealerCheckBox.Location = new System.Drawing.Point(186, 12);
            this.spiritHealerCheckBox.Name = "spiritHealerCheckBox";
            this.spiritHealerCheckBox.Size = new System.Drawing.Size(148, 23);
            this.spiritHealerCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.npcFlagSuperTooltip.SetSuperTooltip(this.spiritHealerCheckBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Makes the creature invisible to alive characters and has the resurrect function.", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.spiritHealerCheckBox.TabIndex = 48;
            this.spiritHealerCheckBox.Text = "SPIRIT_HEALER";
            // 
            // flightMasterCheckBox
            // 
            // 
            // 
            // 
            this.flightMasterCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.flightMasterCheckBox.Location = new System.Drawing.Point(12, 331);
            this.flightMasterCheckBox.Name = "flightMasterCheckBox";
            this.flightMasterCheckBox.Size = new System.Drawing.Size(148, 23);
            this.flightMasterCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.npcFlagSuperTooltip.SetSuperTooltip(this.flightMasterCheckBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Any creature serving as fly master has this.\r\n", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.flightMasterCheckBox.TabIndex = 47;
            this.flightMasterCheckBox.Text = "FLIGHT_MASTER";
            // 
            // repairerCheckBox
            // 
            // 
            // 
            // 
            this.repairerCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.repairerCheckBox.Location = new System.Drawing.Point(12, 302);
            this.repairerCheckBox.Name = "repairerCheckBox";
            this.repairerCheckBox.Size = new System.Drawing.Size(148, 23);
            this.repairerCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.npcFlagSuperTooltip.SetSuperTooltip(this.repairerCheckBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Creatures with this flag can repair items.", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.repairerCheckBox.TabIndex = 46;
            this.repairerCheckBox.Text = "REPAIRER";
            // 
            // vendorReagentCheckBox
            // 
            // 
            // 
            // 
            this.vendorReagentCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.vendorReagentCheckBox.Location = new System.Drawing.Point(12, 273);
            this.vendorReagentCheckBox.Name = "vendorReagentCheckBox";
            this.vendorReagentCheckBox.Size = new System.Drawing.Size(148, 23);
            this.vendorReagentCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.vendorReagentCheckBox.TabIndex = 45;
            this.vendorReagentCheckBox.Text = "VENDOR_REAGENT";
            // 
            // vendorPoisonCheckBox
            // 
            // 
            // 
            // 
            this.vendorPoisonCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.vendorPoisonCheckBox.Location = new System.Drawing.Point(12, 244);
            this.vendorPoisonCheckBox.Name = "vendorPoisonCheckBox";
            this.vendorPoisonCheckBox.Size = new System.Drawing.Size(148, 23);
            this.vendorPoisonCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.vendorPoisonCheckBox.TabIndex = 44;
            this.vendorPoisonCheckBox.Text = "VENDOR_POISON";
            // 
            // vendorFoodCheckBox
            // 
            // 
            // 
            // 
            this.vendorFoodCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.vendorFoodCheckBox.Location = new System.Drawing.Point(12, 215);
            this.vendorFoodCheckBox.Name = "vendorFoodCheckBox";
            this.vendorFoodCheckBox.Size = new System.Drawing.Size(148, 23);
            this.vendorFoodCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.vendorFoodCheckBox.TabIndex = 43;
            this.vendorFoodCheckBox.Text = "VENDOR_FOOD";
            // 
            // vendorAmmoCheckBox
            // 
            // 
            // 
            // 
            this.vendorAmmoCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.vendorAmmoCheckBox.Location = new System.Drawing.Point(12, 186);
            this.vendorAmmoCheckBox.Name = "vendorAmmoCheckBox";
            this.vendorAmmoCheckBox.Size = new System.Drawing.Size(148, 23);
            this.vendorAmmoCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.vendorAmmoCheckBox.TabIndex = 42;
            this.vendorAmmoCheckBox.Text = "VENDOR_AMMO";
            // 
            // vendorCheckBox
            // 
            // 
            // 
            // 
            this.vendorCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.vendorCheckBox.Location = new System.Drawing.Point(12, 157);
            this.vendorCheckBox.Name = "vendorCheckBox";
            this.vendorCheckBox.Size = new System.Drawing.Size(148, 23);
            this.vendorCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.npcFlagSuperTooltip.SetSuperTooltip(this.vendorCheckBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Any creature selling items needs to have this flag.", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.vendorCheckBox.TabIndex = 41;
            this.vendorCheckBox.Text = "VENDOR";
            // 
            // professionTrainerCheckBox
            // 
            // 
            // 
            // 
            this.professionTrainerCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.professionTrainerCheckBox.Location = new System.Drawing.Point(12, 128);
            this.professionTrainerCheckBox.Name = "professionTrainerCheckBox";
            this.professionTrainerCheckBox.Size = new System.Drawing.Size(148, 23);
            this.professionTrainerCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.professionTrainerCheckBox.TabIndex = 40;
            this.professionTrainerCheckBox.Text = "PROFESSION_TRAINER";
            // 
            // classTrainerCheckBox
            // 
            // 
            // 
            // 
            this.classTrainerCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.classTrainerCheckBox.Location = new System.Drawing.Point(12, 99);
            this.classTrainerCheckBox.Name = "classTrainerCheckBox";
            this.classTrainerCheckBox.Size = new System.Drawing.Size(148, 23);
            this.classTrainerCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.classTrainerCheckBox.TabIndex = 39;
            this.classTrainerCheckBox.Text = "CLASS_TRAINER";
            // 
            // trainerCheckBox
            // 
            // 
            // 
            // 
            this.trainerCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.trainerCheckBox.Location = new System.Drawing.Point(12, 70);
            this.trainerCheckBox.Name = "trainerCheckBox";
            this.trainerCheckBox.Size = new System.Drawing.Size(148, 23);
            this.trainerCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.npcFlagSuperTooltip.SetSuperTooltip(this.trainerCheckBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Allows the creature to have a trainer list to teach spells", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.trainerCheckBox.TabIndex = 38;
            this.trainerCheckBox.Text = "TRAINER";
            // 
            // questGiverCheckBox
            // 
            // 
            // 
            // 
            this.questGiverCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.questGiverCheckBox.Location = new System.Drawing.Point(12, 41);
            this.questGiverCheckBox.Name = "questGiverCheckBox";
            this.questGiverCheckBox.Size = new System.Drawing.Size(148, 23);
            this.questGiverCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.npcFlagSuperTooltip.SetSuperTooltip(this.questGiverCheckBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Any creature giving or taking quests needs to have this flag.", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.questGiverCheckBox.TabIndex = 37;
            this.questGiverCheckBox.Text = "QUEST_GIVER";
            // 
            // gossipCheckBox
            // 
            // 
            // 
            // 
            this.gossipCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gossipCheckBox.Location = new System.Drawing.Point(12, 12);
            this.gossipCheckBox.Name = "gossipCheckBox";
            this.gossipCheckBox.Size = new System.Drawing.Size(148, 23);
            this.gossipCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.npcFlagSuperTooltip.SetSuperTooltip(this.gossipCheckBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "If creature has more gossip options, add this flag to bring up a menu.", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.gossipCheckBox.TabIndex = 36;
            this.gossipCheckBox.Text = "GOSSIP";
            // 
            // mailboxCheckBox
            // 
            // 
            // 
            // 
            this.mailboxCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mailboxCheckBox.Location = new System.Drawing.Point(186, 331);
            this.mailboxCheckBox.Name = "mailboxCheckBox";
            this.mailboxCheckBox.Size = new System.Drawing.Size(148, 23);
            this.mailboxCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.npcFlagSuperTooltip.SetSuperTooltip(this.mailboxCheckBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "NPC will act like a mailbox (opens mailbox with right-click)\r\n", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.mailboxCheckBox.TabIndex = 59;
            this.mailboxCheckBox.Text = "MAILBOX";
            // 
            // spellclickCheckBox
            // 
            // 
            // 
            // 
            this.spellclickCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.spellclickCheckBox.Location = new System.Drawing.Point(186, 302);
            this.spellclickCheckBox.Name = "spellclickCheckBox";
            this.spellclickCheckBox.Size = new System.Drawing.Size(148, 23);
            this.spellclickCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.npcFlagSuperTooltip.SetSuperTooltip(this.spellclickCheckBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Needs data on npc_spellclick_spells table\r\n", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.spellclickCheckBox.TabIndex = 58;
            this.spellclickCheckBox.Text = "SPELLCLICK";
            // 
            // guildBankerCheckBox
            // 
            // 
            // 
            // 
            this.guildBankerCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.guildBankerCheckBox.Location = new System.Drawing.Point(186, 273);
            this.guildBankerCheckBox.Name = "guildBankerCheckBox";
            this.guildBankerCheckBox.Size = new System.Drawing.Size(148, 23);
            this.guildBankerCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.guildBankerCheckBox.TabIndex = 57;
            this.guildBankerCheckBox.Text = "GUILD_BANKER";
            // 
            // stableMasterCheckBox
            // 
            // 
            // 
            // 
            this.stableMasterCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.stableMasterCheckBox.Location = new System.Drawing.Point(186, 244);
            this.stableMasterCheckBox.Name = "stableMasterCheckBox";
            this.stableMasterCheckBox.Size = new System.Drawing.Size(148, 23);
            this.stableMasterCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.npcFlagSuperTooltip.SetSuperTooltip(this.stableMasterCheckBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Has the option to stable pets for hunters.\r\n", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.stableMasterCheckBox.TabIndex = 56;
            this.stableMasterCheckBox.Text = "STABLE_MASTER";
            // 
            // auctioneerCheckBox
            // 
            // 
            // 
            // 
            this.auctioneerCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.auctioneerCheckBox.Location = new System.Drawing.Point(186, 215);
            this.auctioneerCheckBox.Name = "auctioneerCheckBox";
            this.auctioneerCheckBox.Size = new System.Drawing.Size(148, 23);
            this.auctioneerCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.npcFlagSuperTooltip.SetSuperTooltip(this.auctioneerCheckBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Allows creature to display auction list.\r\n", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.auctioneerCheckBox.TabIndex = 55;
            this.auctioneerCheckBox.Text = "AUCTIONEER";
            // 
            // battlemasterCheckBox
            // 
            // 
            // 
            // 
            this.battlemasterCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.battlemasterCheckBox.Location = new System.Drawing.Point(186, 186);
            this.battlemasterCheckBox.Name = "battlemasterCheckBox";
            this.battlemasterCheckBox.Size = new System.Drawing.Size(148, 23);
            this.battlemasterCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.npcFlagSuperTooltip.SetSuperTooltip(this.battlemasterCheckBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Creatures with this flag port players to battlegrounds.\r\n", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.battlemasterCheckBox.TabIndex = 54;
            this.battlemasterCheckBox.Text = "BATTLEMASTER";
            // 
            // tabardDesignerCheckBox
            // 
            // 
            // 
            // 
            this.tabardDesignerCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tabardDesignerCheckBox.Location = new System.Drawing.Point(186, 157);
            this.tabardDesignerCheckBox.Name = "tabardDesignerCheckBox";
            this.tabardDesignerCheckBox.Size = new System.Drawing.Size(148, 23);
            this.tabardDesignerCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.npcFlagSuperTooltip.SetSuperTooltip(this.tabardDesignerCheckBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Allows the designing of guild tabards.\r\n", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.tabardDesignerCheckBox.TabIndex = 53;
            this.tabardDesignerCheckBox.Text = "TABARD_DESIGNER";
            // 
            // petitionerCheckBox
            // 
            // 
            // 
            // 
            this.petitionerCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.petitionerCheckBox.Location = new System.Drawing.Point(186, 128);
            this.petitionerCheckBox.Name = "petitionerCheckBox";
            this.petitionerCheckBox.Size = new System.Drawing.Size(148, 23);
            this.petitionerCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.petitionerCheckBox.TabIndex = 52;
            this.petitionerCheckBox.Text = "PETITIONER";
            // 
            // npcFlagSuperTooltip
            // 
            this.npcFlagSuperTooltip.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // FindNPCFlag
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 408);
            this.Controls.Add(this.mailboxCheckBox);
            this.Controls.Add(this.spellclickCheckBox);
            this.Controls.Add(this.guildBankerCheckBox);
            this.Controls.Add(this.stableMasterCheckBox);
            this.Controls.Add(this.auctioneerCheckBox);
            this.Controls.Add(this.battlemasterCheckBox);
            this.Controls.Add(this.tabardDesignerCheckBox);
            this.Controls.Add(this.petitionerCheckBox);
            this.Controls.Add(this.bankerCheckBox);
            this.Controls.Add(this.innkeeperCheckBox);
            this.Controls.Add(this.spiritGuideCheckBox);
            this.Controls.Add(this.spiritHealerCheckBox);
            this.Controls.Add(this.flightMasterCheckBox);
            this.Controls.Add(this.repairerCheckBox);
            this.Controls.Add(this.vendorReagentCheckBox);
            this.Controls.Add(this.vendorPoisonCheckBox);
            this.Controls.Add(this.vendorFoodCheckBox);
            this.Controls.Add(this.vendorAmmoCheckBox);
            this.Controls.Add(this.vendorCheckBox);
            this.Controls.Add(this.professionTrainerCheckBox);
            this.Controls.Add(this.classTrainerCheckBox);
            this.Controls.Add(this.trainerCheckBox);
            this.Controls.Add(this.questGiverCheckBox);
            this.Controls.Add(this.gossipCheckBox);
            this.Controls.Add(this.checkAllButton);
            this.Controls.Add(this.okButton);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindNPCFlag";
            this.Text = "Find NPCFlag";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindNPCFlag_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX checkAllButton;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.Controls.CheckBoxX bankerCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX innkeeperCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX spiritGuideCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX spiritHealerCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX flightMasterCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX repairerCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX vendorReagentCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX vendorPoisonCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX vendorFoodCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX vendorAmmoCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX vendorCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX professionTrainerCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX classTrainerCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX trainerCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX questGiverCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX gossipCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX mailboxCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX spellclickCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX guildBankerCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX stableMasterCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX auctioneerCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX battlemasterCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX tabardDesignerCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX petitionerCheckBox;
        private DevComponents.DotNetBar.SuperTooltip npcFlagSuperTooltip;
    }
}