using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalderaCore;
using CalderaCore.DB;
using Frontend.Controls;

namespace Frontend
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            PopulateCardListBox();
        }

        private void PopulateCardListBox()
        {
            m_lbCards.Items.Clear();
            //List<Card> allcards = CardDB.GetAllLatestCards();
            //foreach (Card card in allcards)
            //{
            //    m_lbCards.Items.Add(card);
            //}
        }

        private void newCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage newCardPage = new TabPage("New Card");
            newCardPage.Controls.Add(new CardEditorControl(newCardPage));
            m_tabControls.Controls.Add(newCardPage);
            
        }

        private void m_tabControls_ControlAdded(object sender, ControlEventArgs e)
        {
            m_tabControls.Visible = true;
        }

        private void m_tabControls_ControlRemoved(object sender, ControlEventArgs e)
        {
            m_tabControls.Visible = m_tabControls.Controls.Count == 0;
        }

        private void m_lvCards_DoubleClick(object sender, EventArgs e)
        {
            ListBox lbSender = (ListBox)sender;
            if (lbSender.SelectedItems.Count == 0)
            {
                return;
            }
            TabPage cardPage = new TabPage();
            Card selectedCard = (Card)(lbSender).SelectedItems[0];
            CardEditorControl editCardControl = new CardEditorControl(cardPage, CardDB.GetLatestVersionFromGUID(selectedCard.Guid));
            cardPage.Controls.Add(editCardControl);
            m_tabControls.Controls.Add(cardPage);
        }

        private void m_btnUpdate_Click(object sender, EventArgs e)
        {
            PopulateCardListBox();
        }

        private void m_lbCards_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newKeywordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void keywordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage keywordPage = new TabPage();
            keywordPage.Controls.Add(new KeywordPage());
            m_tabControls.Controls.Add(keywordPage);
        }

    }
}
