namespace Frontend
{
    partial class CardEditorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_cbxFirepower = new System.Windows.Forms.ComboBox();
            this.m_lblFirepower = new System.Windows.Forms.Label();
            this.m_cbxUseCost = new System.Windows.Forms.ComboBox();
            this.m_cbxType = new System.Windows.Forms.ComboBox();
            this.m_txtName = new System.Windows.Forms.TextBox();
            this.m_lblType = new System.Windows.Forms.Label();
            this.m_lblUseCost = new System.Windows.Forms.Label();
            this.m_lblName = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.m_lblBaseInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_pnlCardInfo = new System.Windows.Forms.Panel();
            this.m_cbxSet = new System.Windows.Forms.ComboBox();
            this.m_cbxRarity = new System.Windows.Forms.ComboBox();
            this.m_lblSet = new System.Windows.Forms.Label();
            this.m_lblRarity = new System.Windows.Forms.Label();
            this.m_txtFlavor = new System.Windows.Forms.TextBox();
            this.m_lblFaction = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_pnlAbilities = new System.Windows.Forms.Panel();
            this.m_btnAddAbility = new System.Windows.Forms.Button();
            this.m_btnSave = new System.Windows.Forms.Button();
            this.m_lblGUID = new System.Windows.Forms.Label();
            this.m_lblVersion = new System.Windows.Forms.Label();
            this.m_pbxCardImage = new System.Windows.Forms.PictureBox();
            this.m_cbxFactions = new System.Windows.Forms.ComboBox();
            this.m_pnlCardInfo.SuspendLayout();
            this.m_pnlAbilities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbxCardImage)).BeginInit();
            this.SuspendLayout();
            // 
            // m_cbxFirepower
            // 
            this.m_cbxFirepower.FormattingEnabled = true;
            this.m_cbxFirepower.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "X"});
            this.m_cbxFirepower.Location = new System.Drawing.Point(113, 154);
            this.m_cbxFirepower.Name = "m_cbxFirepower";
            this.m_cbxFirepower.Size = new System.Drawing.Size(121, 24);
            this.m_cbxFirepower.TabIndex = 33;
            this.m_cbxFirepower.TextChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // m_lblFirepower
            // 
            this.m_lblFirepower.AutoSize = true;
            this.m_lblFirepower.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblFirepower.Location = new System.Drawing.Point(3, 154);
            this.m_lblFirepower.Name = "m_lblFirepower";
            this.m_lblFirepower.Size = new System.Drawing.Size(98, 20);
            this.m_lblFirepower.TabIndex = 31;
            this.m_lblFirepower.Text = "Firepower:";
            // 
            // m_cbxUseCost
            // 
            this.m_cbxUseCost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbxUseCost.FormattingEnabled = true;
            this.m_cbxUseCost.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.m_cbxUseCost.Location = new System.Drawing.Point(113, 119);
            this.m_cbxUseCost.Name = "m_cbxUseCost";
            this.m_cbxUseCost.Size = new System.Drawing.Size(121, 24);
            this.m_cbxUseCost.TabIndex = 26;
            this.m_cbxUseCost.TextChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // m_cbxType
            // 
            this.m_cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbxType.FormattingEnabled = true;
            this.m_cbxType.Items.AddRange(new object[] {
            "Structure",
            "Unit",
            "Upgrade",
            "Interference",
            "Marker"});
            this.m_cbxType.Location = new System.Drawing.Point(113, 84);
            this.m_cbxType.Name = "m_cbxType";
            this.m_cbxType.Size = new System.Drawing.Size(121, 24);
            this.m_cbxType.TabIndex = 25;
            this.m_cbxType.SelectionChangeCommitted += new System.EventHandler(this.m_cbxType_SelectedIndexChanged);
            this.m_cbxType.TextChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // m_txtName
            // 
            this.m_txtName.Location = new System.Drawing.Point(113, 14);
            this.m_txtName.Name = "m_txtName";
            this.m_txtName.Size = new System.Drawing.Size(244, 22);
            this.m_txtName.TabIndex = 24;
            this.m_txtName.TextChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // m_lblType
            // 
            this.m_lblType.AutoSize = true;
            this.m_lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblType.Location = new System.Drawing.Point(3, 84);
            this.m_lblType.Name = "m_lblType";
            this.m_lblType.Size = new System.Drawing.Size(55, 20);
            this.m_lblType.TabIndex = 23;
            this.m_lblType.Text = "Type:";
            // 
            // m_lblUseCost
            // 
            this.m_lblUseCost.AutoSize = true;
            this.m_lblUseCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblUseCost.Location = new System.Drawing.Point(3, 119);
            this.m_lblUseCost.Name = "m_lblUseCost";
            this.m_lblUseCost.Size = new System.Drawing.Size(47, 20);
            this.m_lblUseCost.TabIndex = 21;
            this.m_lblUseCost.Text = "UC: ";
            // 
            // m_lblName
            // 
            this.m_lblName.AutoSize = true;
            this.m_lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblName.Location = new System.Drawing.Point(3, 14);
            this.m_lblName.Name = "m_lblName";
            this.m_lblName.Size = new System.Drawing.Size(69, 20);
            this.m_lblName.TabIndex = 20;
            this.m_lblName.Text = "Name: ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // m_lblBaseInfo
            // 
            this.m_lblBaseInfo.AutoSize = true;
            this.m_lblBaseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblBaseInfo.Location = new System.Drawing.Point(400, 13);
            this.m_lblBaseInfo.Name = "m_lblBaseInfo";
            this.m_lblBaseInfo.Size = new System.Drawing.Size(92, 25);
            this.m_lblBaseInfo.TabIndex = 37;
            this.m_lblBaseInfo.Text = "Core Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(818, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Abilities";
            // 
            // m_pnlCardInfo
            // 
            this.m_pnlCardInfo.Controls.Add(this.m_cbxFactions);
            this.m_pnlCardInfo.Controls.Add(this.m_cbxSet);
            this.m_pnlCardInfo.Controls.Add(this.m_cbxRarity);
            this.m_pnlCardInfo.Controls.Add(this.m_lblSet);
            this.m_pnlCardInfo.Controls.Add(this.m_lblRarity);
            this.m_pnlCardInfo.Controls.Add(this.m_txtFlavor);
            this.m_pnlCardInfo.Controls.Add(this.m_lblFaction);
            this.m_pnlCardInfo.Controls.Add(this.label3);
            this.m_pnlCardInfo.Controls.Add(this.m_lblName);
            this.m_pnlCardInfo.Controls.Add(this.m_lblUseCost);
            this.m_pnlCardInfo.Controls.Add(this.m_lblType);
            this.m_pnlCardInfo.Controls.Add(this.m_txtName);
            this.m_pnlCardInfo.Controls.Add(this.m_cbxType);
            this.m_pnlCardInfo.Controls.Add(this.m_cbxFirepower);
            this.m_pnlCardInfo.Controls.Add(this.m_cbxUseCost);
            this.m_pnlCardInfo.Controls.Add(this.m_lblFirepower);
            this.m_pnlCardInfo.Location = new System.Drawing.Point(258, 41);
            this.m_pnlCardInfo.Name = "m_pnlCardInfo";
            this.m_pnlCardInfo.Size = new System.Drawing.Size(387, 506);
            this.m_pnlCardInfo.TabIndex = 39;
            // 
            // m_cbxSet
            // 
            this.m_cbxSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbxSet.FormattingEnabled = true;
            this.m_cbxSet.Items.AddRange(new object[] {
            "Core",
            "League of Ludicrous"});
            this.m_cbxSet.Location = new System.Drawing.Point(113, 300);
            this.m_cbxSet.Name = "m_cbxSet";
            this.m_cbxSet.Size = new System.Drawing.Size(121, 24);
            this.m_cbxSet.TabIndex = 45;
            // 
            // m_cbxRarity
            // 
            this.m_cbxRarity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbxRarity.FormattingEnabled = true;
            this.m_cbxRarity.Items.AddRange(new object[] {
            "Common",
            "Uncommon",
            "Rare",
            "OMGWTF Rare",
            "Promo",
            "Never Existed"});
            this.m_cbxRarity.Location = new System.Drawing.Point(113, 265);
            this.m_cbxRarity.Name = "m_cbxRarity";
            this.m_cbxRarity.Size = new System.Drawing.Size(121, 24);
            this.m_cbxRarity.TabIndex = 44;
            // 
            // m_lblSet
            // 
            this.m_lblSet.AutoSize = true;
            this.m_lblSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblSet.Location = new System.Drawing.Point(3, 300);
            this.m_lblSet.Name = "m_lblSet";
            this.m_lblSet.Size = new System.Drawing.Size(43, 20);
            this.m_lblSet.TabIndex = 43;
            this.m_lblSet.Text = "Set:";
            // 
            // m_lblRarity
            // 
            this.m_lblRarity.AutoSize = true;
            this.m_lblRarity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblRarity.Location = new System.Drawing.Point(3, 265);
            this.m_lblRarity.Name = "m_lblRarity";
            this.m_lblRarity.Size = new System.Drawing.Size(65, 20);
            this.m_lblRarity.TabIndex = 42;
            this.m_lblRarity.Text = "Rarity:";
            // 
            // m_txtFlavor
            // 
            this.m_txtFlavor.Location = new System.Drawing.Point(113, 329);
            this.m_txtFlavor.Multiline = true;
            this.m_txtFlavor.Name = "m_txtFlavor";
            this.m_txtFlavor.Size = new System.Drawing.Size(269, 45);
            this.m_txtFlavor.TabIndex = 40;
            // 
            // m_lblFaction
            // 
            this.m_lblFaction.AutoSize = true;
            this.m_lblFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblFaction.Location = new System.Drawing.Point(3, 49);
            this.m_lblFaction.Name = "m_lblFaction";
            this.m_lblFaction.Size = new System.Drawing.Size(77, 20);
            this.m_lblFaction.TabIndex = 38;
            this.m_lblFaction.Text = "Faction:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Flavor:";
            // 
            // m_pnlAbilities
            // 
            this.m_pnlAbilities.AutoScroll = true;
            this.m_pnlAbilities.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.m_pnlAbilities.AutoScrollMinSize = new System.Drawing.Size(400, 600);
            this.m_pnlAbilities.Controls.Add(this.m_btnAddAbility);
            this.m_pnlAbilities.Location = new System.Drawing.Point(650, 40);
            this.m_pnlAbilities.Name = "m_pnlAbilities";
            this.m_pnlAbilities.Size = new System.Drawing.Size(330, 635);
            this.m_pnlAbilities.TabIndex = 40;
            // 
            // m_btnAddAbility
            // 
            this.m_btnAddAbility.Location = new System.Drawing.Point(3, 3);
            this.m_btnAddAbility.Name = "m_btnAddAbility";
            this.m_btnAddAbility.Size = new System.Drawing.Size(98, 31);
            this.m_btnAddAbility.TabIndex = 0;
            this.m_btnAddAbility.Text = "Add Ability";
            this.m_btnAddAbility.UseVisualStyleBackColor = true;
            this.m_btnAddAbility.Click += new System.EventHandler(this.m_btnAddAbility_Click);
            // 
            // m_btnSave
            // 
            this.m_btnSave.Location = new System.Drawing.Point(35, 349);
            this.m_btnSave.Name = "m_btnSave";
            this.m_btnSave.Size = new System.Drawing.Size(75, 23);
            this.m_btnSave.TabIndex = 41;
            this.m_btnSave.Text = "Save";
            this.m_btnSave.UseVisualStyleBackColor = true;
            this.m_btnSave.Click += new System.EventHandler(this.m_btnSave_Click);
            // 
            // m_lblGUID
            // 
            this.m_lblGUID.AutoSize = true;
            this.m_lblGUID.Location = new System.Drawing.Point(35, 309);
            this.m_lblGUID.Name = "m_lblGUID";
            this.m_lblGUID.Size = new System.Drawing.Size(64, 17);
            this.m_lblGUID.TabIndex = 42;
            this.m_lblGUID.Text = "Guid: {0}";
            // 
            // m_lblVersion
            // 
            this.m_lblVersion.AutoSize = true;
            this.m_lblVersion.Location = new System.Drawing.Point(35, 326);
            this.m_lblVersion.Name = "m_lblVersion";
            this.m_lblVersion.Size = new System.Drawing.Size(72, 17);
            this.m_lblVersion.TabIndex = 43;
            this.m_lblVersion.Text = "Version: 0";
            // 
            // m_pbxCardImage
            // 
            this.m_pbxCardImage.BackColor = System.Drawing.Color.White;
            this.m_pbxCardImage.Location = new System.Drawing.Point(35, 26);
            this.m_pbxCardImage.Name = "m_pbxCardImage";
            this.m_pbxCardImage.Size = new System.Drawing.Size(200, 280);
            this.m_pbxCardImage.TabIndex = 44;
            this.m_pbxCardImage.TabStop = false;
            this.m_pbxCardImage.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // 
            // m_cbxFactions
            // 
            this.m_cbxFactions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbxFactions.FormattingEnabled = true;
            this.m_cbxFactions.Location = new System.Drawing.Point(113, 43);
            this.m_cbxFactions.Name = "m_cbxFactions";
            this.m_cbxFactions.Size = new System.Drawing.Size(121, 24);
            this.m_cbxFactions.TabIndex = 46;
            // 
            // CardEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_pbxCardImage);
            this.Controls.Add(this.m_lblVersion);
            this.Controls.Add(this.m_lblGUID);
            this.Controls.Add(this.m_btnSave);
            this.Controls.Add(this.m_pnlAbilities);
            this.Controls.Add(this.m_pnlCardInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_lblBaseInfo);
            this.Name = "CardEditorControl";
            this.Size = new System.Drawing.Size(1000, 680);
            this.m_pnlCardInfo.ResumeLayout(false);
            this.m_pnlCardInfo.PerformLayout();
            this.m_pnlAbilities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_pbxCardImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox m_cbxFirepower;
        private System.Windows.Forms.Label m_lblFirepower;
        private System.Windows.Forms.ComboBox m_cbxUseCost;
        private System.Windows.Forms.ComboBox m_cbxType;
        private System.Windows.Forms.TextBox m_txtName;
        private System.Windows.Forms.Label m_lblType;
        private System.Windows.Forms.Label m_lblUseCost;
        private System.Windows.Forms.Label m_lblName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label m_lblBaseInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel m_pnlCardInfo;
        private System.Windows.Forms.TextBox m_txtFlavor;
        private System.Windows.Forms.Label m_lblFaction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel m_pnlAbilities;
        private System.Windows.Forms.Button m_btnSave;
        private System.Windows.Forms.Label m_lblGUID;
        private System.Windows.Forms.Label m_lblVersion;
        private System.Windows.Forms.PictureBox m_pbxCardImage;
        private System.Windows.Forms.Button m_btnAddAbility;
        private System.Windows.Forms.ComboBox m_cbxSet;
        private System.Windows.Forms.ComboBox m_cbxRarity;
        private System.Windows.Forms.Label m_lblSet;
        private System.Windows.Forms.Label m_lblRarity;
        private System.Windows.Forms.ComboBox m_cbxFactions;
    }
}
