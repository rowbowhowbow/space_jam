namespace Frontend.Controls
{
    partial class KeywordEditor
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
            this.m_txtAbilityName = new System.Windows.Forms.TextBox();
            this.m_lblName = new System.Windows.Forms.Label();
            this.m_lblAbility = new System.Windows.Forms.Label();
            this.m_cmbHasXValue = new System.Windows.Forms.CheckBox();
            this.m_lblID = new System.Windows.Forms.Label();
            this.m_lblGuid = new System.Windows.Forms.Label();
            this.m_btnSave = new System.Windows.Forms.Button();
            this.m_AbilityEditor = new Frontend.AbilityEditor(this);
            this.SuspendLayout();
            // 
            // m_txtAbilityName
            // 
            this.m_txtAbilityName.Location = new System.Drawing.Point(105, -2);
            this.m_txtAbilityName.Name = "m_txtAbilityName";
            this.m_txtAbilityName.Size = new System.Drawing.Size(139, 22);
            this.m_txtAbilityName.TabIndex = 1;
            this.m_txtAbilityName.TextChanged += new System.EventHandler(this.SomethingChanged);
            // 
            // m_lblName
            // 
            this.m_lblName.AutoSize = true;
            this.m_lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.m_lblName.Location = new System.Drawing.Point(3, 0);
            this.m_lblName.Name = "m_lblName";
            this.m_lblName.Size = new System.Drawing.Size(63, 20);
            this.m_lblName.TabIndex = 2;
            this.m_lblName.Text = "Name:";
            // 
            // m_lblAbility
            // 
            this.m_lblAbility.AutoSize = true;
            this.m_lblAbility.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.m_lblAbility.Location = new System.Drawing.Point(3, 26);
            this.m_lblAbility.Name = "m_lblAbility";
            this.m_lblAbility.Size = new System.Drawing.Size(67, 20);
            this.m_lblAbility.TabIndex = 3;
            this.m_lblAbility.Text = "Ability:";
            // 
            // m_cmbHasXValue
            // 
            this.m_cmbHasXValue.AutoSize = true;
            this.m_cmbHasXValue.Location = new System.Drawing.Point(105, 182);
            this.m_cmbHasXValue.Name = "m_cmbHasXValue";
            this.m_cmbHasXValue.Size = new System.Drawing.Size(108, 21);
            this.m_cmbHasXValue.TabIndex = 4;
            this.m_cmbHasXValue.Text = "Has X Value";
            this.m_cmbHasXValue.UseVisualStyleBackColor = true;
            // 
            // m_lblID
            // 
            this.m_lblID.AutoSize = true;
            this.m_lblID.Location = new System.Drawing.Point(251, 0);
            this.m_lblID.Name = "m_lblID";
            this.m_lblID.Size = new System.Drawing.Size(25, 17);
            this.m_lblID.TabIndex = 5;
            this.m_lblID.Text = "ID:";
            // 
            // m_lblGuid
            // 
            this.m_lblGuid.AutoSize = true;
            this.m_lblGuid.Location = new System.Drawing.Point(316, -2);
            this.m_lblGuid.Name = "m_lblGuid";
            this.m_lblGuid.Size = new System.Drawing.Size(0, 17);
            this.m_lblGuid.TabIndex = 6;
            // 
            // m_btnSave
            // 
            this.m_btnSave.Location = new System.Drawing.Point(105, 219);
            this.m_btnSave.Name = "m_btnSave";
            this.m_btnSave.Size = new System.Drawing.Size(75, 23);
            this.m_btnSave.TabIndex = 7;
            this.m_btnSave.Text = "Save";
            this.m_btnSave.UseVisualStyleBackColor = true;
            this.m_btnSave.Click += new System.EventHandler(this.m_btnSave_Click);
            // 
            // m_AbilityEditor
            // 
            this.m_AbilityEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_AbilityEditor.Location = new System.Drawing.Point(105, 26);
            this.m_AbilityEditor.Name = "m_AbilityEditor";
            this.m_AbilityEditor.Size = new System.Drawing.Size(300, 150);
            this.m_AbilityEditor.TabIndex = 0;
            this.m_AbilityEditor.OnSomethingChanged += new Frontend.AbilityChangedHandler(this.SomethingChanged);
            // 
            // KeywordEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_btnSave);
            this.Controls.Add(this.m_lblGuid);
            this.Controls.Add(this.m_lblID);
            this.Controls.Add(this.m_cmbHasXValue);
            this.Controls.Add(this.m_lblAbility);
            this.Controls.Add(this.m_lblName);
            this.Controls.Add(this.m_txtAbilityName);
            this.Controls.Add(this.m_AbilityEditor);
            this.Name = "KeywordEditor";
            this.Size = new System.Drawing.Size(427, 254);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AbilityEditor m_AbilityEditor;
        private System.Windows.Forms.TextBox m_txtAbilityName;
        private System.Windows.Forms.Label m_lblName;
        private System.Windows.Forms.Label m_lblAbility;
        private System.Windows.Forms.CheckBox m_cmbHasXValue;
        private System.Windows.Forms.Label m_lblID;
        private System.Windows.Forms.Label m_lblGuid;
        private System.Windows.Forms.Button m_btnSave;
    }
}
