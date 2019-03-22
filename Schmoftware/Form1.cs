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
        #region Constructor

        public Form1()
        {
            InitializeComponent();

            Fakultaet = new Fakultaet();
        }

        #endregion Constructor

        #region Properties

        /// <summary>
        /// Klasse zum Berechnen einer Fakultät
        /// </summary>
        private Fakultaet Fakultaet { get; set; }

        #endregion Properties

        #region Events

        private void Calc_Click(object sender, EventArgs e)
        {
            ulong number = 0;

            if (UInt64.TryParse(Input.Text, out number))
            {
                Output.Text = Fakultaet.GetFakultaet(number).ToString();
            }
            else
            {
                MessageBox.Show("Geben Sie eine Zahl ein Sie Held.");
            }
        }

        #endregion Events
    }
}
