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
    public partial class FormBoilerTable : Form
    {
        public FormBoilerTable()
        {
            InitializeComponent();
        }

        private void FormBoilerTable_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sFUDataSet28.Boiler". При необходимости она может быть перемещена или удалена.
            this.boilerTableAdapter.Fill(this.sFUDataSet28.Boiler);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            short Boiler_number =Convert.ToInt16 (textBox1.Text);
            int Boiler_code = Convert.ToInt32 (textBox2.Text);
            DateTime Installation_date = Convert.ToDateTime(textBox3.Text);
            DateTime Test_date = Convert.ToDateTime(textBox4.Text);
            // Create a new row.
            SFUDataSet28.BoilerRow newBoilerRow;
            newBoilerRow = this.sFUDataSet28.Boiler.NewBoilerRow();
            newBoilerRow.Boiler_number = Boiler_number;
            newBoilerRow.Boiler_code = Boiler_code;
            newBoilerRow.Installation_date = Installation_date;
            newBoilerRow.Test_date = Test_date;
            // Add the row to the Region table
            this.sFUDataSet28.Boiler.Rows.Add(newBoilerRow);

            // Save the new row to the database
            this.boilerTableAdapter.Update(this.sFUDataSet28.Boiler);
        }
    }
}