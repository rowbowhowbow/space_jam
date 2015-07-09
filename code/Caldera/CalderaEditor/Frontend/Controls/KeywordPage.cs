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
    public partial class KeywordPage : UserControl
    {
        public KeywordPage()
        {
            InitializeComponent();
            UpdateKeywordList();
        }

        private void UpdateKeywordList()
        {
            List<Keyword> keywordList = CalderaCore.DB.AbilityDB.GetLatestKeywords();
            m_lbxKeywords.Items.AddRange(keywordList.ToArray());
        }

        private void KeywordPage_Load(object sender, EventArgs e)
        {

        }
    }
}
