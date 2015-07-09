using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonExSerializer;

namespace CalderaCore
{
    public class Keyword : Ability
    {
        int m_ID;
        String m_Guid;
        String m_Name;
        bool m_HasXValue;
        int m_Version;
        bool m_IsAttribute;

        [JsonExIgnore]
        public int ID
        {
            get { return m_ID; }
            set { m_ID = value; }
        }

        [JsonExIgnore]
        public String Guid
        {
            get { return m_Guid; }
            set { m_Guid = value; }
        }

        [JsonExIgnore]
        public String Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        [JsonExIgnore]
        public bool HasXValue
        {
            get { return m_HasXValue; }
            set { m_HasXValue = value; }
        }

        [JsonExIgnore]
        public int Version
        {
            get { return m_Version; }
            set { m_Version = value; }
        }

        public bool IsAttribute
        {
            get { return m_IsAttribute; }
            set { m_IsAttribute = value; }
        }

        public override string ToString()
        {
            String retString = String.Empty;
            retString += m_Name;
            if (m_HasXValue)
            {
                retString += " {X}";
            }
            retString += " - " + m_Text;

            return retString;
        }
    }

    public class KeywordInstance : Keyword
    {
        int m_XValue;

        [JsonExIgnore]
        public int XValue
        {
            get { return m_XValue; }
            set { m_XValue = value; }
        }

        public override string ToString()
        {
            return base.ToString().Replace("{X}", m_XValue.ToString());
        }
    }
}
