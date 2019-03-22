using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schmoftware
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MaxSchmax_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetText());
        }

        private string GetText()
        {
            return "MaxSchmax ist der King";
        }
    }
}
