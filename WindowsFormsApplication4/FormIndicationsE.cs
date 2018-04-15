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
    public partial class FormIndicationsE : Form
    {
        public FormIndicationsE()
        {
            InitializeComponent();
        }

        private void FormIndicationsE_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sFUDataSet31.Indications". При необходимости она может быть перемещена или удалена.
            this.indicationsTableAdapter.Fill(this.sFUDataSet31.Indications);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            short Num_Indications = Convert.ToInt16(textBox1.Text);
            short Counter_number = Convert.ToInt16(textBox2.Text);
            DateTime Date_of_indications = Convert.ToDateTime(textBox3.Text);
            String Month_and_year = textBox4.Text;
            int Indications_before = Convert.ToInt32(textBox5.Text);
            int Indications_after = Convert.ToInt32(textBox6.Text);
            // Create a new row.
            SFUDataSet31.IndicationsRow NewIndicationsRow;
            NewIndicationsRow = this.sFUDataSet31.Indications.NewIndicationsRow();
            NewIndicationsRow.Num_Indications = Num_Indications;
            NewIndicationsRow.Counter_number = Counter_number;
            NewIndicationsRow.Date_of_indications = Date_of_indications;
            NewIndicationsRow.Indications_before = Indications_before;
            NewIndicationsRow.Indications_after = Indications_after;
            NewIndicationsRow.Month_and_year = Month_and_year;
            // Add the row to the Region table
            this.sFUDataSet31.Indications.Rows.Add(NewIndicationsRow);

            // Save the new row to the database
            this.indicationsTableAdapter.Update(this.sFUDataSet31.Indications);
        }
    }
}
