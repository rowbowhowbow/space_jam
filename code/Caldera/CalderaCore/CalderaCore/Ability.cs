using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalderaCore
{
    public class Ability
    {
        protected AbilityActivations m_ActivationType;

        protected String m_Text;

        protected String m_TriggerScript;
        protected String m_ActionScript;
        

        public AbilityActivations ActivationType
        {
            get { return m_ActivationType; }
            set { m_ActivationType = value; }
        }

        public String Text
        {
            get { return m_Text; }
            set { m_Text = value; }
        }

        public String TriggerScript
        {
            get { return m_TriggerScript; }
            set { m_TriggerScript = value; }
        }

        public String ActionScript
        {
            get { return m_ActionScript; }
            set { m_ActionScript = value; }
        }

        public override string ToString()
        {
            String abilityString = String.Empty;

            abilityString += m_Text;
            return abilityString;
        }
    }
}
