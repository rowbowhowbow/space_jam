namespace Frontend
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m_tsiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newKeywordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_tsiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.m_tsiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.m_lbCards = new System.Windows.Forms.ListBox();
            this.m_btnUpdate = new System.Windows.Forms.Button();
            this.m_tabControls = new Frontend.Controls.TabControlC();
            this.tabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keywordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tsiFile,
            this.m_tsiEdit,
            this.m_tsiOptions,
            this.tabToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // m_tsiFile
            // 
            this.m_tsiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCardToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.newKeywordToolStripMenuItem});
            this.m_tsiFile.Name = "m_tsiFile";
            this.m_tsiFile.Size = new System.Drawing.Size(44, 24);
            this.m_tsiFile.Text = "File";
            // 
            // newCardToolStripMenuItem
            // 
            this.newCardToolStripMenuItem.Name = "newCardToolStripMenuItem";
            this.newCardToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.newCardToolStripMenuItem.Text = "New Card";
            this.newCardToolStripMenuItem.Click += new System.EventHandler(this.newCardToolStripMenuItem_Click);
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.saveAllToolStripMenuItem.Text = "Save All";
            // 
            // newKeywordToolStripMenuItem
            // 
            this.newKeywordToolStripMenuItem.Name = "newKeywordToolStripMenuItem";
            this.newKeywordToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.newKeywordToolStripMenuItem.Text = "New Keyword";
            this.newKeywordToolStripMenuItem.Click += new System.EventHandler(this.newKeywordToolStripMenuItem_Click);
            // 
            // m_tsiEdit
            // 
            this.m_tsiEdit.Name = "m_tsiEdit";
            this.m_tsiEdit.Size = new System.Drawing.Size(47, 24);
            this.m_tsiEdit.Text = "Edit";
            // 
            // m_tsiOptions
            // 
            this.m_tsiOptions.Name = "m_tsiOptions";
            this.m_tsiOptions.Size = new System.Drawing.Size(73, 24);
            this.m_tsiOptions.Text = "Options";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // m_lbCards
            // 
            this.m_lbCards.FormattingEnabled = true;
            this.m_lbCards.ItemHeight = 16;
            this.m_lbCards.Location = new System.Drawing.Point(0, 60);
            this.m_lbCards.Name = "m_lbCards";
            this.m_lbCards.Size = new System.Drawing.Size(153, 644);
            this.m_lbCards.TabIndex = 3;
            this.m_lbCards.SelectedIndexChanged += new System.EventHandler(this.m_lbCards_SelectedIndexChanged);
            this.m_lbCards.DoubleClick += new System.EventHandler(this.m_lvCards_DoubleClick);
            // 
            // m_btnUpdate
            // 
            this.m_btnUpdate.Location = new System.Drawing.Point(12, 707);
            this.m_btnUpdate.Name = "m_btnUpdate";
            this.m_btnUpdate.Size = new System.Drawing.Size(113, 23);
            this.m_btnUpdate.TabIndex = 4;
            this.m_btnUpdate.Text = "Update";
            this.m_btnUpdate.UseVisualStyleBackColor = true;
            this.m_btnUpdate.Click += new System.EventHandler(this.m_btnUpdate_Click);
            // 
            // m_tabControls
            // 
            this.m_tabControls.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.m_tabControls.Location = new System.Drawing.Point(160, 60);
            this.m_tabControls.Name = "m_tabControls";
            this.m_tabControls.SelectedIndex = 0;
            this.m_tabControls.Size = new System.Drawing.Size(1000, 680);
            this.m_tabControls.TabIndex = 2;
            this.m_tabControls.Visible = false;
            this.m_tabControls.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.m_tabControls_ControlAdded);
            this.m_tabControls.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.m_tabControls_ControlRemoved);
            // 
            // tabToolStripMenuItem
            // 
            this.tabToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keywordsToolStripMenuItem,
            this.factionsToolStripMenuItem});
            this.tabToolStripMenuItem.Name = "tabToolStripMenuItem";
            this.tabToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.tabToolStripMenuItem.Text = "Tab";
            // 
            // keywordsToolStripMenuItem
            // 
            this.keywordsToolStripMenuItem.Name = "keywordsToolStripMenuItem";
            this.keywordsToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.keywordsToolStripMenuItem.Text = "Keywords";
            this.keywordsToolStripMenuItem.Click += new System.EventHandler(this.keywordsToolStripMenuItem_Click);
            // 
            // factionsToolStripMenuItem
            // 
            this.factionsToolStripMenuItem.Name = "factionsToolStripMenuItem";
            this.factionsToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.factionsToolStripMenuItem.Text = "Factions";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1182, 755);
            this.Controls.Add(this.m_btnUpdate);
            this.Controls.Add(this.m_lbCards);
            this.Controls.Add(this.m_tabControls);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Caldera Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m_tsiFile;
        private System.Windows.Forms.ToolStripMenuItem m_tsiEdit;
        private System.Windows.Forms.ToolStripMenuItem m_tsiOptions;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem newCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ListBox m_lbCards;
        private System.Windows.Forms.Button m_btnUpdate;
        private System.Windows.Forms.ToolStripMenuItem newKeywordToolStripMenuItem;
        private Controls.TabControlC m_tabControls;
        private System.Windows.Forms.ToolStripMenuItem tabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keywordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factionsToolStripMenuItem;
    }
}

