using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalderaCore.Cards
{
    public class Building : Card
    {
        protected Dictionary<String, int> m_ReupValues;
        protected Player m_Controller;
        protected int m_Strength;

        public override CardTypes Type
        {
            get
            {
                return CardTypes.Building;
            }
        }
        public Player Controller
        {
            get { return m_Controller; }
            set { m_Controller = value; }
        }

        public Dictionary<String, int> ReupValues
        {
            get { return m_ReupValues; }
            set { m_ReupValues = value; }
        }

        public int Strength
        {
            get { return m_Strength; }
            set { m_Strength = value; }
        }
    }

    //public class Base : Building
    //{
    //    protected int m_CurrentHP;
    //    protected int m_MaxHP;
    //    protected int m_ReupHP;

    //    [JsonExSerializer.JsonExIgnore]
    //    public int CurrentHP
    //    {
    //        get { return m_CurrentHP; }
    //        set { m_CurrentHP = value; }
    //    }

    //    public int MaxHP
    //    {
    //        get { return m_MaxHP; }
    //        set { m_MaxHP = value; }
    //    }

    //    public int ReupHP
    //    {
    //        get { return m_ReupHP; }
    //        set { m_ReupHP = value; }
    //    }
    //}
}
