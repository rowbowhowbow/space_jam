namespace Frontend.Controls
{
    partial class CardDataTemplateEditor
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
            this.m_lblTemplateName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.m_btnAddStat1 = new System.Windows.Forms.Button();
            this.m_lblStats1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_lblTemplateName
            // 
            this.m_lblTemplateName.AutoSize = true;
            this.m_lblTemplateName.Location = new System.Drawing.Point(3, 15);
            this.m_lblTemplateName.Name = "m_lblTemplateName";
            this.m_lblTemplateName.Size = new System.Drawing.Size(112, 17);
            this.m_lblTemplateName.TabIndex = 0;
            this.m_lblTemplateName.Text = "Template Name:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // m_btnAddStat1
            // 
            this.m_btnAddStat1.Location = new System.Drawing.Point(6, 51);
            this.m_btnAddStat1.Name = "m_btnAddStat1";
            this.m_btnAddStat1.Size = new System.Drawing.Size(27, 23);
            this.m_btnAddStat1.TabIndex = 2;
            this.m_btnAddStat1.Text = "+";
            this.m_btnAddStat1.UseVisualStyleBackColor = true;
            // 
            // m_lblStats1
            // 
            this.m_lblStats1.AutoSize = true;
            this.m_lblStats1.Location = new System.Drawing.Point(39, 57);
            this.m_lblStats1.Name = "m_lblStats1";
            this.m_lblStats1.Size = new System.Drawing.Size(49, 17);
            this.m_lblStats1.TabIndex = 3;
            this.m_lblStats1.Text = "Stat 1:";
            // 
            // CardDataTemplateEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_lblStats1);
            this.Controls.Add(this.m_btnAddStat1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.m_lblTemplateName);
            this.Name = "CardDataTemplateEditor";
            this.Size = new System.Drawing.Size(330, 567);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_lblTemplateName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button m_btnAddStat1;
        private System.Windows.Forms.Label m_lblStats1;
    }
}
