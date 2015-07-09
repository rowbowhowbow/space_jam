using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalderaCore;

namespace Frontend.Controls
{
    public partial class KeywordEditor : UserControl
    {
        Keyword m_Keyword;

        public KeywordEditor()
        {
            InitializeComponent();
            m_AbilityEditor.Parent = this;
            m_Keyword = new Keyword();
        }

        public KeywordEditor(Keyword keywordToEdit)
        {
            m_Keyword = keywordToEdit;
            InitializeComponent();
            m_AbilityEditor.Parent = this;
            
        }

        private void m_btnSave_Click(object sender, EventArgs e)
        {
            CalderaCore.DB.AbilityDB.SaveKeyword(m_Keyword);
        }

        private void SomethingChanged(object sender, EventArgs e)
        {
            if (sender == m_txtAbilityName)
            {
                m_Keyword.Name = ((TextBox)sender).Text;
            }
            else if (sender == m_AbilityEditor)
            {

            }
        }


    }
}
