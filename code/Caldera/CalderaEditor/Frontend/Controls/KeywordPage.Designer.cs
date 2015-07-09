namespace Frontend.Controls
{
    partial class KeywordPage
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
            this.m_lbxKeywords = new System.Windows.Forms.ListBox();
            this.m_btnNewKeyword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_lbxKeywords
            // 
            this.m_lbxKeywords.FormattingEnabled = true;
            this.m_lbxKeywords.ItemHeight = 16;
            this.m_lbxKeywords.Location = new System.Drawing.Point(4, 46);
            this.m_lbxKeywords.Name = "m_lbxKeywords";
            this.m_lbxKeywords.Size = new System.Drawing.Size(120, 580);
            this.m_lbxKeywords.TabIndex = 0;
            // 
            // m_btnNewKeyword
            // 
            this.m_btnNewKeyword.Location = new System.Drawing.Point(4, 633);
            this.m_btnNewKeyword.Name = "m_btnNewKeyword";
            this.m_btnNewKeyword.Size = new System.Drawing.Size(120, 23);
            this.m_btnNewKeyword.TabIndex = 1;
            this.m_btnNewKeyword.Text = "New Keyword";
            this.m_btnNewKeyword.UseVisualStyleBackColor = true;
            // 
            // KeywordPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_btnNewKeyword);
            this.Controls.Add(this.m_lbxKeywords);
            this.Name = "KeywordPage";
            this.Size = new System.Drawing.Size(1000, 680);
            this.Load += new System.EventHandler(this.KeywordPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox m_lbxKeywords;
        private System.Windows.Forms.Button m_btnNewKeyword;
    }
}
