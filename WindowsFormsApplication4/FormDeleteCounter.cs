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
    public partial class FormDeleteCounter : Form
    {
        public FormDeleteCounter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String counter_code = textBox1.Text;

            //SFUDataSet26.CounterRow сounterRow;
            //сounterRow.Counter_code = counter_code;
            //sFUDataSet26.Counter.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDeleteCounter_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sFUDataSet26.Counter". При необходимости она может быть перемещена или удалена.
            this.counterTableAdapter.Fill(this.sFUDataSet26.Counter);

        }
    }
}
