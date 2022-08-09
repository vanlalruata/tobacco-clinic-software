using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCS
{
    public partial class ReasonToLost : UserControl
    {
        public string reasonfor = "";
        public ReasonToLost()
        {
            InitializeComponent();
        }

        private void reason_SelectedIndexChanged(object sender, EventArgs e)
        {
            reasonfor = reason.Text;
        }
    }
}
