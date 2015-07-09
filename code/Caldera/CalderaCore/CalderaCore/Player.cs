using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalderaCore
{
    public class Player
    {
        String m_Name;
        List<Card> m_Hand;

        public String Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        public List<Card> Hand
        {
            get { return m_Hand; }
            set { m_Hand = value; }
        }

    }
}
