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
    public partial class FormHeat2 : Form
    {
        public FormHeat2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHeatBuilding HeatBuilding = new FormHeatBuilding();
            HeatBuilding.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHeatReadings HeatReadings = new FormHeatReadings();
            HeatReadings.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
