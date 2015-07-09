using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalderaCore.Cards
{
    public class Unit : Card
    {
        int m_BaseFirepower;
        int m_FirepowerUpgrades;

        public override CardTypes Type
        {
            get { return CardTypes.Unit; }
        }

        public int BaseFirepower
        {
            get { return m_BaseFirepower; }
            set { m_BaseFirepower = value; }
        }

        public int FirepowerUpgrades
        {
            get { return m_FirepowerUpgrades; }
            set { m_FirepowerUpgrades = value; }
        }

        public int TotalFirepower
        {
            get { return m_BaseFirepower + m_FirepowerUpgrades; }
        }
    }
}
