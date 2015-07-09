using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Frontend.Controls;
using CalderaCore;

namespace Frontend
{
    public delegate void AbilityChangedHandler(object sender, EventArgs e);

    public partial class AbilityEditor : UserControl
    {
        UserControl m_Parent;
        Ability m_Ability;
        bool m_loading;

        public event AbilityChangedHandler OnSomethingChanged;

        public AbilityEditor(UserControl parent) : base ()
        {
            m_loading = true; 
            m_Parent = parent;
            InitializeComponent();
            m_Ability = new Ability();
            Init();
            m_loading = false;
        }

        public AbilityEditor(UserControl parent, Ability abilityToEdit)
        {
            m_loading = true;
            m_Parent = parent;
            InitializeComponent();
            m_Ability = abilityToEdit;
            Init();
            m_loading = false;
        }

        public AbilityEditor() : base ()
        {
            InitializeComponent();
        }

        public void Init()
        {
            if (m_Parent is KeywordEditor)
            {
                m_cbxAbilityGroup.Enabled = false;
                m_cbxAbilityGroup.Text = "Keyword";
                m_cbxKeywords.Enabled = false;
                m_cbxKeywords.Visible = false;
            }
            LoadAbility(m_Ability);
        }

        public Ability Ability
        {
            get
            {
                return m_Ability;
            }
        }

        public void LoadAbility(Ability abilityToLoad)
        {
            if (!m_loading)
            {
                m_Ability = abilityToLoad;
            }
            m_txtAbilityText.Text = abilityToLoad.Text;
            m_cbxTriggerType.Text = abilityToLoad.ActivationType.ToString();
            m_loading = false;
        }



        private void m_cbxTriggerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool showCostStuff = m_cbxTriggerType.Text == "Pay";
            //m_lblCost.Visible = showCostStuff;
            //m_txtCost.Visible = showCostStuff;
            OnChanged(sender, e);
        }

        private void m_txtAbilityText_TextChanged(object sender, EventArgs e)
        {
            OnChanged(sender, e);
        }

        private void m_txtCost_TextChanged(object sender, EventArgs e)
        {
            OnChanged(sender, e);
        }

        protected virtual void OnChanged(object sender, EventArgs e)
        {
            if (m_loading)
            {
                return;
            }
            if (m_cbxAbilityGroup.Text == "Keyword" && !(m_Parent is KeywordEditor))
            {
                KeywordInstance ability = new KeywordInstance();
                m_cbxKeywords.Visible = true;
                ability.Guid = m_cbxKeywords.SelectedValue.ToString();
                //TODO: extract
                if (sender == m_cbxKeywords)
                {
                    Keyword keywordToInstance = CalderaCore.DB.AbilityDB.GetLatestVersionofKeywordbyID(ability.Guid);
                    ability.Text = keywordToInstance.Text;
                    ability.ActivationType = keywordToInstance.ActivationType;
                    ability.HasXValue = keywordToInstance.HasXValue;
                    ability.ID = keywordToInstance.ID;
                    ability.IsAttribute = keywordToInstance.IsAttribute;
                    ability.Name = keywordToInstance.Name;
                    ability.Version = keywordToInstance.Version;
                    m_cbxTriggerType.Enabled = false;
                    m_txtAbilityText.Enabled = false;
                    m_Ability = ability;
                }
            }
            else if (m_cbxAbilityGroup.Text == "Ability")
            {
                m_Ability = new Ability();
                m_Ability.Text = m_txtAbilityText.Text;
                m_Ability.ActivationType = (AbilityActivations)Enum.Parse(typeof(AbilityActivations), m_txtAbilityText.Text);

            }

            if (OnSomethingChanged != null)
                OnSomethingChanged(sender, e);
        }

        private void AbilityEditor_Load(object sender, EventArgs e)
        {

        }

        
    }
}
