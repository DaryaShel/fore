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
    public partial class FormCounter : Form
    {
        public FormCounter()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAddCounter add_counter = new FormAddCounter();
            add_counter.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCurentCounter form3 = new FormCurentCounter();
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormUpdateCounter update_counter = new FormUpdateCounter();
            update_counter.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormDeleteCounter delete_counter = new FormDeleteCounter();
            delete_counter.ShowDialog();
        }
    }
}
