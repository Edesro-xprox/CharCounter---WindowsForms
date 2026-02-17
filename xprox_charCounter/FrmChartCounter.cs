using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xprox_charCounter
{
    public partial class FrmChartCounter : Form
    {
        public FrmChartCounter()
        {
            InitializeComponent();
        }

        private void txtChange_TextChanged(object sender, EventArgs e)
        {
            string textWithoutEnter = txtChange.Text.Replace("\r","").Replace("\n","");
            labelCount.Text = "Número de carácteres:  " + textWithoutEnter.Length.ToString();
        }

        private void labelCount_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtChange.Clear();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtChange.Text);
        }
    }
}
