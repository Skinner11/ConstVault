using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstVault
{
    public partial class ConstVault : Form
    {
        public ConstVault()
        {
            InitializeComponent();
            ConstElement e1 = new ConstElement("Some HEX color", "#01f2dd", ConstElement.Type.Auto);
            ConstElement e2 = new ConstElement("RGBA, hopefully", "RGBA(102,102,102,0.2)", ConstElement.Type.Auto);
        }
    }
}
