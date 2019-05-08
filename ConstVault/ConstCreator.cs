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
    /// <summary>
    /// The form will hold a ConstElement, which is "empty" if we're creating a new one,
    /// or will get set to the one passed in to the constructor for editing it.
    /// </summary>
    public partial class ConstCreator : Form
    {
        private ConstElement current;

        public ConstCreator(ref ConstElement toEdit)
        {
            InitializeComponent();

            if (toEdit != null)
                Edit(ref toEdit);
            else
            {

            }
        }

        public static ConstElement Edit(ref ConstElement toEdit)
        {
            //TODO Editing of existing Const via GUI
            return null;
        }
    }
}
