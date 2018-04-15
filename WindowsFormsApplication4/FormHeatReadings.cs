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
    public partial class FormHeatReadings : Form
    {
        public FormHeatReadings()
        {
            InitializeComponent();
        }

        private void FormHeatReadings_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sFUDataSet16.wvHeat". При необходимости она может быть перемещена или удалена.
            this.wvHeatTableAdapter.Fill(this.sFUDataSet16.wvHeat);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            e.Graphics.DrawImage(objBmp, 250, 90);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormHeatTable HeatTable = new FormHeatTable();
            HeatTable.ShowDialog();
        }
    }
}
