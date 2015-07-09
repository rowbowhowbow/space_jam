using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalderaCore
{
    public enum PlayState
    {
        Editing,
        InDeck,
        InHand,
        Played
    }

    public struct CardState
    {
        public PlayState PlayState;
        public bool FaceUp;
        public Player Owner;
    }

    public abstract class Card
    {
        protected int m_ID;
        protected String m_Guid;
        protected String m_Name;
        protected String m_Faction;


        protected int m_UseCost;
        protected List<Ability> m_Abilities;
        protected List<KeywordInstance> m_KeywordAbilities;


        protected String m_Set;
        protected String m_ArtPath;
        protected int m_Rarity;
        protected Credits m_Credits;
        protected int m_Version;
        protected String m_FlavorText;


        #region Properties

        public int ID
        {
            get { return m_ID; }
            set { m_ID = value; }
        }

        public String Guid
        {
            get { return m_Guid; }
            set { m_Guid = value; }
        }

        public String Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        public String Faction
        {
            get { return m_Faction; }
            set { m_Faction = value; }
        }

        public abstract CardTypes Type
        {
            get;
        }

        public int UseCost
        {
            get { return m_UseCost; }
            set { m_UseCost = value; }
        }

        public List<Ability> Abilities
        {
            get
            {
                if (m_Abilities == null)
                {
                    m_Abilities = new List<Ability>();
                }
                return m_Abilities;
            }
            set { m_Abilities = value; }
        }

        public List<KeywordInstance> KeywordAbilities
        {
            get
            {
                if (m_KeywordAbilities == null)
                {
                    m_KeywordAbilities = new List<KeywordInstance>();
                }
                return m_KeywordAbilities;
            }
            set { m_KeywordAbilities = value; }
        }
        

        public String Set
        {
            get { return m_Set; }
            set { m_Set = value; }
        }

        public String ArtPath
        {
            get { return m_ArtPath; }
            set { m_ArtPath = value; }
        }

        public Credits Creds
        {
            get { return m_Credits; }
            set { m_Credits = value; }
        }

        public int Version
        {
            get { return m_Version; }
            set { m_Version = value; }
        }

        public String Flavor
        {
            get { return m_FlavorText; }
            set { m_FlavorText = value; }
        }

        public int Rarity
        {
            get { return m_Rarity; }
            set { m_Rarity = value; }
        }


        #endregion

        public Card()
        {
            m_Guid = String.Empty;
            m_Name = String.Empty;
            m_Faction = String.Empty;
            m_UseCost = 0;
            m_Abilities = new List<Ability>();
            m_Set = String.Empty;
            m_ArtPath = String.Empty;
            m_Credits = new Credits();
            m_Version = 0;
            m_FlavorText = String.Empty;
        }

        public override string ToString()
        {
            return m_Name + " - #" + m_Version.ToString();
        }



    }
}
