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
    public partial class FormHeatTable : Form
    {
        public FormHeatTable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void FormHeatTable_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sFUDataSet29.Heat". При необходимости она может быть перемещена или удалена.
            this.heatTableAdapter.Fill(this.sFUDataSet29.Heat);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            short Num_heat = Convert.ToInt16(textBox1.Text);
            short Boiler_number = Convert.ToInt16(textBox2.Text);
            int Indications_before = Convert.ToInt32(textBox3.Text);
            int Indications_after = Convert.ToInt32(textBox4.Text);
            short Num_tariff = Convert.ToInt16(textBox5.Text);
            // Create a new row.
            SFUDataSet29.HeatRow NewHeatRow;
            NewHeatRow = this.sFUDataSet29.Heat.NewHeatRow();
            NewHeatRow.Num_heat = Num_heat;
            NewHeatRow.Boiler_number = Boiler_number;
            NewHeatRow.Indications_before = Indications_before;
            NewHeatRow.Indications_after = Indications_after;
            NewHeatRow.Num_tariff = Num_tariff;
          
            // Add the row to the Region table
            this.sFUDataSet29.Heat.Rows.Add(NewHeatRow);

            // Save the new row to the database
            this.heatTableAdapter.Update(this.sFUDataSet29.Heat);
        }
    }
}
