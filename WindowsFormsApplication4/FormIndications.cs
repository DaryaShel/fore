using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class FormIndications : Form
    {
        public FormIndications()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormElectricity FormElectricity = new FormElectricity();
            FormElectricity.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormHotwater FormHotwater = new FormHotwater();
            FormHotwater.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormColdwater FormColdwater = new FormColdwater();
            FormColdwater.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormGas FormGas = new FormGas();
            FormGas.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormFullreport FormFullreport = new FormFullreport();
            FormFullreport.ShowDialog();
        }
    }
}
