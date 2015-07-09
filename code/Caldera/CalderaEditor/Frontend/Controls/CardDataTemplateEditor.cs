using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend.Controls
{
    public partial class CardDataTemplateEditor : UserControl
    {
        List<Label> m_StatLabels;
        List<TextBox> m_StatNames;
        List<Button> m_AddRemoveButtons;

        public CardDataTemplateEditor()
        {
            InitializeComponent();
        }
    }
}
