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
using CalderaCore.Cards;

namespace Frontend
{
    public partial class CardEditorControl : UserControl
    {

        TabPage m_tabParent;
        Card m_Card;
        bool m_Loading;

        List<AbilityEditor> m_aeAbilityDisplay;

        bool m_ChangesOccured = false;

        public CardEditorControl(TabPage parent)
        {
            m_Loading = true;
            m_tabParent = parent;
            m_Card = MakeDefaultCard();
            InitializeComponent();
            m_aeAbilityDisplay = new List<AbilityEditor>();
            PopulateFields();
            m_Loading = false;
        }

        public CardEditorControl(TabPage parent, Card cardToEdit)
        {
            m_Loading = true;
            m_tabParent = parent;
            m_Card = cardToEdit;
            InitializeComponent();
            m_aeAbilityDisplay = new List<AbilityEditor>();
            PopulateFields();
            m_Loading = false;
        }

        private Card MakeDefaultCard()
        {
            Card defaultCard = new Unit();
            defaultCard.Faction = "None";
            defaultCard.UseCost = 0;
            defaultCard.Name = "New Card";
            defaultCard.Set = "Core";
            return defaultCard;
        }

        private void PopulateFields()
        {
            m_lblGUID.Text = String.Format("ID: {0}", m_Card.ID);
            m_txtName.Text = m_Card.Name;
            m_cbxFactions.Text = m_Card.Faction;
            m_cbxType.Text = m_Card.Type.ToString();
            m_cbxUseCost.Text = m_Card.UseCost.ToString();
            if (m_Card.Type != CardTypes.Unit)
            {
                m_lblFirepower.Visible = false;
                m_cbxFirepower.Visible = false;
            }
            else
            {
            }
            m_lblVersion.Text = "Version: " + m_Card.Version.ToString();
            m_txtFlavor.Text = m_Card.Flavor;
            foreach(Ability cardAbility in m_Card.Abilities)
            {
                m_aeAbilityDisplay.Add(new AbilityEditor(this, cardAbility));
            }

            SetupAbilityDisplay();
        }

        private void SetupAbilityDisplay()
        {
            
            int xStart = 5;
            int yStart = 50;
            int ySpacing = 160;

            for (int displayIndex = 0; displayIndex < m_aeAbilityDisplay.Count; ++displayIndex)
            {
                m_aeAbilityDisplay[displayIndex].Location = new Point(xStart, yStart + ySpacing * displayIndex);
                if (!m_pnlAbilities.Controls.Contains(m_aeAbilityDisplay[displayIndex]))
                {
                    m_pnlAbilities.Controls.Add(m_aeAbilityDisplay[displayIndex]);
                    m_aeAbilityDisplay[displayIndex].OnSomethingChanged += new AbilityChangedHandler(SomethingChanged);
                }
            }
        }

        private void DrawCard()
        {

        }

        private void SomethingChanged(object sender, EventArgs e)
        {
            m_tabParent.Text = m_txtName.Text;
            m_ChangesOccured = true;
            PutFieldDataOnCard();
            m_pbxCardImage.Invalidate();
        }

        private void m_btnSave_Click(object sender, EventArgs e)
        {
            if (!m_ChangesOccured)
            {
                return;
            }
            PutFieldDataOnCard();
            CalderaCore.DB.CardDB.SaveCardToDBVersioned(m_Card);
        }

        private void PutFieldDataOnCard()
        {
            if (m_Loading)
            {
                return;
            }
            if (m_Card == null)
            {
                m_Card = new Unit();
            }
            m_Card.Name = m_txtName.Text;
            m_Card.Faction = m_cbxFactions.Text;
            //m_Card.Type = (CardTypes)Enum.Parse(typeof(CardTypes), m_cbxType.Text);
            m_Card.UseCost = Int32.Parse(m_cbxUseCost.Text);
            m_Card.Set = m_cbxSet.Text;
            m_Card.Rarity = m_cbxRarity.SelectedIndex;
            if (m_Card.Type == CardTypes.Unit)
            {
                Unit cardEditing = (Unit)m_Card;
                cardEditing.BaseFirepower = Int32.Parse(m_cbxFirepower.Text);
            }

            m_Card.Flavor = m_txtFlavor.Text;
            if (m_Card.Creds == null)
            {
                m_Card.Creds = new Credits();
            }
            m_Card.Abilities.Clear();
            foreach (AbilityEditor abilityrep in m_aeAbilityDisplay)
            {
                m_Card.Abilities.Add(abilityrep.Ability);
            }
            m_Card.Creds.Designer = "RH";
        }

       


        private void Card_Paint(object sender, PaintEventArgs e)
        {
            float xLocation = 15.0f;
            float yStart = 20.0f;
            float ySpacing = 20.0f;
            int spacingSection = 0;
            int xSpace = 175;
            PictureBox pbxCardImage = (PictureBox)sender;
            Font font = new System.Drawing.Font(FontFamily.GenericSerif, 8.5f);
            Brush brush = new SolidBrush(Color.Black);
            e.Graphics.DrawString(m_txtName.Text, font, brush, new PointF(xLocation, yStart + ySpacing * spacingSection++));
            e.Graphics.DrawString(m_cbxType.Text, font, brush, new PointF(xLocation, yStart + ySpacing * spacingSection++));
            e.Graphics.DrawString(m_cbxUseCost.Text, font, brush, new PointF(xLocation, yStart + ySpacing * spacingSection++));
            e.Graphics.DrawString(m_cbxFactions.Text, font, brush, new PointF(xLocation, yStart + ySpacing * spacingSection++));
            
            String firepowerShields = String.Format("[{0}]", m_cbxFirepower.Text);
            e.Graphics.DrawString(firepowerShields, font, brush, new PointF(xLocation, yStart + ySpacing * spacingSection++));
            float currentLocation = yStart + ySpacing * spacingSection;
            foreach (AbilityEditor abilityToDraw in m_aeAbilityDisplay)
            {
                SizeF rectangleSize = e.Graphics.MeasureString(abilityToDraw.Ability.ToString(), font, xSpace);
                e.Graphics.DrawString(abilityToDraw.Ability.ToString(), font, brush, new RectangleF(new PointF(xLocation, currentLocation), rectangleSize));
                currentLocation += rectangleSize.Height;
            }
        }

        private void m_cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool showUseCosts = m_cbxType.Text != "Marker";
            m_lblUseCost.Visible = showUseCosts;
            m_cbxUseCost.Visible = showUseCosts;

            bool showUnitStuff = m_cbxType.Text == "Unit" || !showUseCosts;
            m_lblFirepower.Visible = showUnitStuff;
            m_cbxFirepower.Visible = showUnitStuff;

        }

        private void m_btnAddAbility_Click(object sender, EventArgs e)
        {
            AbilityEditor abilityEditorControl = new AbilityEditor(this);
            m_aeAbilityDisplay.Add(abilityEditorControl);
            SetupAbilityDisplay();
        }
    }
}
