using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalderaCore
{
    public class Credits
    {
        String m_Designer;
        String m_Artist;
        String m_Copyright;

        #region Properties
        [JsonExSerializer.JsonExIgnore]
        public String Designer
        {
            get { return m_Designer; }
            set { m_Designer = value; }
        }

        public String Artist
        {
            get { return m_Artist; }
            set { m_Artist = value; }
        }

        public String Copyright
        {
            get { return m_Copyright; }
            set { m_Copyright = value; }
        }
        #endregion

        public Credits()
        {
            m_Designer = String.Empty;
            m_Artist = String.Empty;
            m_Copyright = String.Empty;
        }
    }
}
