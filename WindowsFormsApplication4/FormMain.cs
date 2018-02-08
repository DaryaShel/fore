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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCounter form2 = new FormCounter();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBoilers form5 = new FormBoilers();
            form5.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormIndications FormIndications = new FormIndications();
            FormIndications.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormToPay to_pay = new FormToPay();
            to_pay.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormHeat2 Heat = new FormHeat2();
            Heat.ShowDialog();
        }
    }
}
