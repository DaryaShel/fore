﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sFUDataSet3.wvBoiler". При необходимости она может быть перемещена или удалена.
            this.wvBoilerTableAdapter.Fill(this.sFUDataSet3.wvBoiler);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
