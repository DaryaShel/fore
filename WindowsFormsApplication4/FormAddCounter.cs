using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    public partial class FormAddCounter : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=SFU;Integrated Security=True";
        string sql = "SELECT * FROM Counter";
        public FormAddCounter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            String counter_code = textBox1.Text;
            String resource_code = textBox2.Text;
            DateTime test_date = Convert.ToDateTime(textBox3.Text);
            // Create a new row.
            SFUDataSet27.CounterRow newCounterRow;
            newCounterRow = this.sFUDataSet27.Counter.NewCounterRow();
            newCounterRow.Counter_code = counter_code;
            newCounterRow.Resource_code = resource_code;
            newCounterRow.Test_date = test_date;
            // Add the row to the Region table
            this.sFUDataSet27.Counter.Rows.Add(newCounterRow);

            // Save the new row to the database
            this.counterTableAdapter.Update(this.sFUDataSet27.Counter);
        }

        private void FormAddCounter_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sFUDataSet27.Counter". При необходимости она может быть перемещена или удалена.
            this.counterTableAdapter.Fill(this.sFUDataSet27.Counter);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sFUDataSet25.Counter". При необходимости она может быть перемещена или удалена.
            this.counterTableAdapter.Fill(this.sFUDataSet27.Counter);           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
