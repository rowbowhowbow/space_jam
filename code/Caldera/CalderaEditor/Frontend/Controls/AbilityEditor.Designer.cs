namespace Frontend
{
    partial class AbilityEditor
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
            this.m_txtAbilityText = new System.Windows.Forms.TextBox();
            this.m_cbxTriggerType = new System.Windows.Forms.ComboBox();
            this.m_btnRemove = new System.Windows.Forms.Button();
            this.m_cbxAbilityGroup = new System.Windows.Forms.ComboBox();
            this.m_cbxKeywords = new System.Windows.Forms.ComboBox();
            this.m_txtAbilityTriggerScript = new System.Windows.Forms.TextBox();
            this.m_OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.m_lblTrigger = new System.Windows.Forms.Label();
            this.m_lblAction = new System.Windows.Forms.Label();
            this.m_txtActionScriptFile = new System.Windows.Forms.TextBox();
            this.m_btnFindTrigger = new System.Windows.Forms.Button();
            this.m_btnFindAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_txtAbilityText
            // 
            this.m_txtAbilityText.Location = new System.Drawing.Point(3, 63);
            this.m_txtAbilityText.Multiline = true;
            this.m_txtAbilityText.Name = "m_txtAbilityText";
            this.m_txtAbilityText.Size = new System.Drawing.Size(292, 55);
            this.m_txtAbilityText.TabIndex = 0;
            this.m_txtAbilityText.TextChanged += new System.EventHandler(this.m_txtAbilityText_TextChanged);
            // 
            // m_cbxTriggerType
            // 
            this.m_cbxTriggerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbxTriggerType.FormattingEnabled = true;
            this.m_cbxTriggerType.Items.AddRange(new object[] {
            "Pay",
            "Trigger",
            "State"});
            this.m_cbxTriggerType.Location = new System.Drawing.Point(6, 33);
            this.m_cbxTriggerType.Name = "m_cbxTriggerType";
            this.m_cbxTriggerType.Size = new System.Drawing.Size(132, 24);
            this.m_cbxTriggerType.TabIndex = 1;
            this.m_cbxTriggerType.SelectedIndexChanged += new System.EventHandler(this.m_cbxTriggerType_SelectedIndexChanged);
            // 
            // m_btnRemove
            // 
            this.m_btnRemove.Location = new System.Drawing.Point(262, 33);
            this.m_btnRemove.Name = "m_btnRemove";
            this.m_btnRemove.Size = new System.Drawing.Size(33, 23);
            this.m_btnRemove.TabIndex = 4;
            this.m_btnRemove.Text = "X";
            this.m_btnRemove.UseVisualStyleBackColor = true;
            // 
            // m_cbxAbilityGroup
            // 
            this.m_cbxAbilityGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbxAbilityGroup.FormattingEnabled = true;
            this.m_cbxAbilityGroup.Items.AddRange(new object[] {
            "Ability",
            "Keyword"});
            this.m_cbxAbilityGroup.Location = new System.Drawing.Point(6, 4);
            this.m_cbxAbilityGroup.Name = "m_cbxAbilityGroup";
            this.m_cbxAbilityGroup.Size = new System.Drawing.Size(132, 24);
            this.m_cbxAbilityGroup.TabIndex = 5;
            // 
            // m_cbxKeywords
            // 
            this.m_cbxKeywords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbxKeywords.FormattingEnabled = true;
            this.m_cbxKeywords.Location = new System.Drawing.Point(144, 4);
            this.m_cbxKeywords.Name = "m_cbxKeywords";
            this.m_cbxKeywords.Size = new System.Drawing.Size(151, 24);
            this.m_cbxKeywords.TabIndex = 6;
            // 
            // m_txtAbilityTriggerScript
            // 
            this.m_txtAbilityTriggerScript.Location = new System.Drawing.Point(70, 124);
            this.m_txtAbilityTriggerScript.Name = "m_txtAbilityTriggerScript";
            this.m_txtAbilityTriggerScript.Size = new System.Drawing.Size(182, 22);
            this.m_txtAbilityTriggerScript.TabIndex = 7;
            // 
            // m_OpenFileDialog
            // 
            this.m_OpenFileDialog.FileName = "openFileDialog1";
            // 
            // m_lblTrigger
            // 
            this.m_lblTrigger.AutoSize = true;
            this.m_lblTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblTrigger.Location = new System.Drawing.Point(3, 124);
            this.m_lblTrigger.Name = "m_lblTrigger";
            this.m_lblTrigger.Size = new System.Drawing.Size(67, 20);
            this.m_lblTrigger.TabIndex = 8;
            this.m_lblTrigger.Text = "Trigger:";
            // 
            // m_lblAction
            // 
            this.m_lblAction.AutoSize = true;
            this.m_lblAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblAction.Location = new System.Drawing.Point(3, 156);
            this.m_lblAction.Name = "m_lblAction";
            this.m_lblAction.Size = new System.Drawing.Size(61, 20);
            this.m_lblAction.TabIndex = 10;
            this.m_lblAction.Text = "Action:";
            // 
            // m_txtActionScriptFile
            // 
            this.m_txtActionScriptFile.Location = new System.Drawing.Point(70, 156);
            this.m_txtActionScriptFile.Name = "m_txtActionScriptFile";
            this.m_txtActionScriptFile.Size = new System.Drawing.Size(182, 22);
            this.m_txtActionScriptFile.TabIndex = 9;
            // 
            // m_btnFindTrigger
            // 
            this.m_btnFindTrigger.Location = new System.Drawing.Point(258, 124);
            this.m_btnFindTrigger.Name = "m_btnFindTrigger";
            this.m_btnFindTrigger.Size = new System.Drawing.Size(27, 23);
            this.m_btnFindTrigger.TabIndex = 11;
            this.m_btnFindTrigger.Text = "...";
            this.m_btnFindTrigger.UseVisualStyleBackColor = true;
            // 
            // m_btnFindAction
            // 
            this.m_btnFindAction.Location = new System.Drawing.Point(258, 156);
            this.m_btnFindAction.Name = "m_btnFindAction";
            this.m_btnFindAction.Size = new System.Drawing.Size(27, 23);
            this.m_btnFindAction.TabIndex = 12;
            this.m_btnFindAction.Text = "...";
            this.m_btnFindAction.UseVisualStyleBackColor = true;
            // 
            // AbilityEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.m_btnFindAction);
            this.Controls.Add(this.m_btnFindTrigger);
            this.Controls.Add(this.m_lblAction);
            this.Controls.Add(this.m_txtActionScriptFile);
            this.Controls.Add(this.m_lblTrigger);
            this.Controls.Add(this.m_txtAbilityTriggerScript);
            this.Controls.Add(this.m_cbxKeywords);
            this.Controls.Add(this.m_cbxAbilityGroup);
            this.Controls.Add(this.m_btnRemove);
            this.Controls.Add(this.m_cbxTriggerType);
            this.Controls.Add(this.m_txtAbilityText);
            this.Name = "AbilityEditor";
            this.Size = new System.Drawing.Size(300, 185);
            this.Load += new System.EventHandler(this.AbilityEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_txtAbilityText;
        private System.Windows.Forms.ComboBox m_cbxTriggerType;
        private System.Windows.Forms.Button m_btnRemove;
        private System.Windows.Forms.ComboBox m_cbxAbilityGroup;
        private System.Windows.Forms.ComboBox m_cbxKeywords;
        private System.Windows.Forms.TextBox m_txtAbilityTriggerScript;
        private System.Windows.Forms.OpenFileDialog m_OpenFileDialog;
        private System.Windows.Forms.Label m_lblTrigger;
        private System.Windows.Forms.Label m_lblAction;
        private System.Windows.Forms.TextBox m_txtActionScriptFile;
        private System.Windows.Forms.Button m_btnFindTrigger;
        private System.Windows.Forms.Button m_btnFindAction;
    }
}
